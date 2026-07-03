using System;
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

        public frmReportes()
        {
            InitializeComponent();
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}