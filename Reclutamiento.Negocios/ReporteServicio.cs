using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;
using Reclutamiento.Datos;
using System.IO;

namespace Reclutamiento.Negocio
{
    public class ReporteServicio
    {
        public ReporteServicio()
        {
            // QuestPDF requiere configurar la licencia (gratis para uso educativo/comunitario)
            QuestPDF.Settings.License = LicenseType.Community;
        }

        // genera un reporte en PDF a partir de encabezados y filas genericas (para frmReportes)
        public byte[] GenerarReporteGeneral(string titulo, string[] encabezados, List<string[]> filas)
        {
            using (var stream = new MemoryStream())
            {
                QuestPDF.Fluent.Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Margin(30);
                        page.Header().Text(titulo).FontSize(18).Bold().FontColor(Colors.Blue.Darken3);

                        page.Content().PaddingTop(15).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                foreach (var _ in encabezados)
                                    columns.RelativeColumn();
                            });

                            // encabezados
                            table.Header(header =>
                            {
                                foreach (var titulo_col in encabezados)
                                {
                                    header.Cell().Background(Colors.Blue.Darken3).Padding(5)
                                        .Text(titulo_col).FontColor(Colors.White).Bold();
                                }
                            });

                            // filas
                            foreach (var fila in filas)
                            {
                                foreach (var valor in fila)
                                {
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).Text(valor ?? "");
                                }
                            }
                        });

                        page.Footer().AlignCenter().Text(x =>
                        {
                            x.Span("Generado el ");
                            x.Span(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                        });
                    });
                }).GeneratePdf(stream);

                return stream.ToArray();
            }
        }

        // genera el reporte de Decision Final (datos + comentarios) y le fusiona el CV en PDF si existe
        public byte[] GenerarReporteDecisionFinal(DecisionFinal decision, Candidato candidato, Vacante vacante, byte[] cvPdfBytes)
        {
            byte[] reporteBytes;

            using (var stream = new MemoryStream())
            {
                QuestPDF.Fluent.Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Margin(40);
                        page.Header().Column(col =>
                        {
                            col.Item().Text("Reporte de Decision Final").FontSize(20).Bold().FontColor(Colors.Blue.Darken3);
                            col.Item().Text($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(9).FontColor(Colors.Grey.Darken1);
                        });

                        page.Content().PaddingTop(20).Column(col =>
                        {
                            col.Spacing(8);

                            col.Item().Text("Datos del Candidato").FontSize(13).Bold().FontColor(Colors.Blue.Darken2);
                            col.Item().Text($"Nombre: {candidato.Nombre}");
                            col.Item().Text($"Cedula: {candidato.Cedula}");
                            col.Item().Text($"Email: {candidato.Email}");
                            col.Item().Text($"Telefono: {candidato.Telefono}");
                            col.Item().Text($"Tipo: {(candidato.EsInterno ? "Interno" : "Externo")}");

                            col.Item().PaddingTop(10).Text("Vacante").FontSize(13).Bold().FontColor(Colors.Blue.Darken2);
                            col.Item().Text($"Titulo: {vacante.Titulo}");

                            col.Item().PaddingTop(10).Text("Decision Final").FontSize(13).Bold().FontColor(Colors.Blue.Darken2);
                            col.Item().Text($"Resultado: {decision.Decision}").FontSize(12).Bold();
                            col.Item().Text($"Fecha: {decision.Fecha:dd/MM/yyyy}");
                            col.Item().PaddingTop(5).Text("Comentarios:").Bold();
                            col.Item().Text(string.IsNullOrEmpty(decision.Comentario) ? "(Sin comentarios)" : decision.Comentario);

                            if (cvPdfBytes != null)
                                col.Item().PaddingTop(15).Text("El CV del candidato esta adjunto a continuacion.").Italic().FontColor(Colors.Grey.Darken1);
                            else
                                col.Item().PaddingTop(15).Text("Este candidato no tiene CV guardado en el sistema.").Italic().FontColor(Colors.Grey.Darken1);
                        });
                    });
                }).GeneratePdf(stream);

                reporteBytes = stream.ToArray();
            }

            // si no hay CV, devolvemos solo el reporte
            if (cvPdfBytes == null || cvPdfBytes.Length == 0)
                return reporteBytes;

            // fusionamos el reporte con el CV en un solo PDF usando PdfSharpCore
            using (var outputStream = new MemoryStream())
            {
                PdfDocument documentoFinal = new PdfDocument();

                using (var reporteStream = new MemoryStream(reporteBytes))
                {
                    PdfDocument reportePdf = PdfReader.Open(reporteStream, PdfDocumentOpenMode.Import);
                    foreach (PdfSharpCore.Pdf.PdfPage p in reportePdf.Pages)
                        documentoFinal.AddPage(p);
                }

                using (var cvStream = new MemoryStream(cvPdfBytes))
                {
                    PdfDocument cvPdf = PdfReader.Open(cvStream, PdfDocumentOpenMode.Import);
                    foreach (PdfSharpCore.Pdf.PdfPage p in cvPdf.Pages)
                        documentoFinal.AddPage(p);
                }

                documentoFinal.Save(outputStream, false);
                return outputStream.ToArray();
            }
        }
    }
}