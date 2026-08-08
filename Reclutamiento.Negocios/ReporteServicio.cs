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

        // Genera un reporte en PDF a partir de encabezados y filas genericas (para frmReportes)
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

                            table.Header(header =>
                            {
                                foreach (var titulo_col in encabezados)
                                {
                                    header.Cell().Background(Colors.Blue.Darken3).Padding(5)
                                        .Text(titulo_col).FontColor(Colors.White).Bold();
                                }
                            });

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

        // Genera el reporte de Decision Final (datos + comentarios) y le fusiona el CV en PDF si existe
        // logoBytes se recibe ya listo desde la capa de Presentacion (Negocio no debe depender de Presentacion)
        public byte[] GenerarReporteDecisionFinal(DecisionFinal decision, Candidato candidato, Vacante vacante, byte[] cvPdfBytes, byte[] logoBytes)
        {
            byte[] reporteBytes;

            using (var stream = new MemoryStream())
            {
                QuestPDF.Fluent.Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Margin(40);
                        page.DefaultTextStyle(x => x.FontSize(11));

                        page.Header().Column(col =>
                        {
                            if (logoBytes != null)
                            {
                                col.Item().AlignCenter().Height(80).Image(logoBytes).FitHeight();
                                col.Item().PaddingTop(8);
                            }

                            col.Item().AlignCenter().Text("Reporte de Decision Final")
                                .FontSize(20).Bold().FontColor(Colors.Blue.Darken3);
                            col.Item().AlignCenter().Text($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}")
                                .FontSize(9).FontColor(Colors.Grey.Darken1);
                        });

                        page.Content().PaddingTop(25).Column(col =>
                        {
                            col.Spacing(8);

                            col.Item().AlignCenter().Text("Datos del Candidato").FontSize(13).Bold().FontColor(Colors.Blue.Darken2);
                            col.Item().AlignCenter().Text($"Nombre: {candidato.Nombre}");
                            col.Item().AlignCenter().Text($"Cedula: {candidato.Cedula}");
                            col.Item().AlignCenter().Text($"Email: {candidato.Email}");
                            col.Item().AlignCenter().Text($"Telefono: {candidato.Telefono}");
                            col.Item().AlignCenter().Text($"Tipo: {(candidato.EsInterno ? "Interno" : "Externo")}");

                            col.Item().PaddingTop(10).AlignCenter().Text("Vacante").FontSize(13).Bold().FontColor(Colors.Blue.Darken2);
                            col.Item().AlignCenter().Text($"Titulo: {vacante.Titulo}");

                            col.Item().PaddingTop(10).AlignCenter().Text("Decision Final").FontSize(13).Bold().FontColor(Colors.Blue.Darken2);
                            col.Item().AlignCenter().Text($"Resultado: {decision.Decision}").FontSize(12).Bold();
                            col.Item().AlignCenter().Text($"Fecha: {decision.Fecha:dd/MM/yyyy}");
                            col.Item().PaddingTop(5).AlignCenter().Text("Comentarios:").Bold();
                            col.Item().AlignCenter().Text(string.IsNullOrEmpty(decision.Comentario) ? "(Sin comentarios)" : decision.Comentario);

                            if (cvPdfBytes != null)
                                col.Item().PaddingTop(15).AlignCenter().Text("El CV del candidato esta adjunto a continuacion.").Italic().FontColor(Colors.Grey.Darken1);
                            else
                                col.Item().PaddingTop(15).AlignCenter().Text("Este candidato no tiene CV guardado en el sistema.").Italic().FontColor(Colors.Grey.Darken1);
                        });
                    });
                }).GeneratePdf(stream);

                reporteBytes = stream.ToArray();
            }

            if (cvPdfBytes == null || cvPdfBytes.Length == 0)
                return reporteBytes;

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