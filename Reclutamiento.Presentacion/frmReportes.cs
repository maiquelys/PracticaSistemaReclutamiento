using System;
using System.IO;
using System.Windows.Forms;
using Reclutamiento.Negocio;
using Reclutamiento.Datos;

namespace Reclutamiento.Presentacion
{
    public partial class frmReportes : Form
    {
        private CandidatoServicio _candidatoServicio = new CandidatoServicio();
        private VacanteServicio _vacanteServicio = new VacanteServicio();
        private EntrevistaServicio _entrevistaServicio = new EntrevistaServicio();
        private ReporteServicio _reporteServicio = new ReporteServicio();

        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            reportesToolStripMenuItem.Font = new Font(reportesToolStripMenuItem.Font, FontStyle.Bold);

        }

        // Reporte candidatos internos - usa lambda Func
        private void btnCandidatosInternos_Click(object sender, EventArgs e)
        {
            var resultado = _candidatoServicio.FiltrarPorTipo(true);
            dgvReporte.DataSource = resultado;
            lblResultado.Text = $"Candidatos internos encontrados: {resultado.Count}";
        }

        // Reporte candidatos externos - usa lambda Func
        private void btnCandidatosExternos_Click(object sender, EventArgs e)
        {
            var resultado = _candidatoServicio.FiltrarPorTipo(false);
            dgvReporte.DataSource = resultado;
            lblResultado.Text = $"Candidatos externos encontrados: {resultado.Count}";
        }

        // Reporte vacantes activas - usa lambda Func
        private void btnVacantesActivas_Click(object sender, EventArgs e)
        {
            var resultado = _vacanteServicio.FiltrarPorEstado("Activa");
            dgvReporte.DataSource = resultado;
            lblResultado.Text = $"Vacantes activas encontradas: {resultado.Count}";
        }

        // Reporte entrevistas con puntuacion alta - usa lambda Func
        private void btnEntrevistasAltas_Click(object sender, EventArgs e)
        {
            var resultado = _entrevistaServicio.FiltrarPorPuntuacion(70);
            dgvReporte.DataSource = resultado;
            lblResultado.Text = $"Entrevistas con puntuacion >= 70: {resultado.Count}";
        }

        // Exporta lo que esta actualmente en el grid a un PDF
        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReporte.Rows.Count == 0 || dgvReporte.DataSource == null)
                {
                    MessageBox.Show("Primero genera un reporte para poder exportarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // tomamos los encabezados visibles del grid (sin columnas ocultas)
                var columnasVisibles = new System.Collections.Generic.List<DataGridViewColumn>();
                foreach (DataGridViewColumn col in dgvReporte.Columns)
                {
                    if (col.Visible)
                        columnasVisibles.Add(col);
                }

                string[] encabezados = new string[columnasVisibles.Count];
                for (int i = 0; i < columnasVisibles.Count; i++)
                    encabezados[i] = columnasVisibles[i].HeaderText;

                var filas = new System.Collections.Generic.List<string[]>();
                foreach (DataGridViewRow row in dgvReporte.Rows)
                {
                    if (row.IsNewRow) continue;

                    string[] valores = new string[columnasVisibles.Count];
                    for (int i = 0; i < columnasVisibles.Count; i++)
                    {
                        var valor = row.Cells[columnasVisibles[i].Index].Value;
                        valores[i] = valor?.ToString() ?? "";
                    }
                    filas.Add(valores);
                }

                byte[] pdfBytes = _reporteServicio.GenerarReporteGeneral(lblResultado.Text, encabezados, filas);

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
                    sfd.FileName = "Reporte.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(sfd.FileName, pdfBytes);
                        MessageBox.Show("Reporte exportado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        // metodos del Menustrip (barra de arriba) agregada por Nayelis
        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCandidatos frm = new frmCandidatos();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void vacantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVacantes frm = new frmVacantes();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void entrevistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntrevistas frm = new frmEntrevistas();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void decisionFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDecisionFinal frm = new frmDecisionFinal();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}