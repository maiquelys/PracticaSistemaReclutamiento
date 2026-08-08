using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Reclutamiento.Negocio;
using Reclutamiento.Datos;

namespace Reclutamiento.Presentacion
{
    public partial class frmDecisionFinal : Form
    {
        private DecisionFinalServicio _servicio = new DecisionFinalServicio();
        private CandidatoServicio _candidatoServicio = new CandidatoServicio();
        private VacanteServicio _vacanteServicio = new VacanteServicio();
        private ReporteServicio _reporteServicio = new ReporteServicio();

        public frmDecisionFinal()
        {
            InitializeComponent();
        }

        private void frmDecisionFinal_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarDecisiones();
            decisionFinalToolStripMenuItem.Font = new Font(decisionFinalToolStripMenuItem.Font, FontStyle.Bold);
        }

        private void CargarCombos()
        {
            cboCandidato.DataSource = _candidatoServicio.ObtenerCandidatos();
            cboCandidato.DisplayMember = "Nombre";
            cboCandidato.ValueMember = "CandidatoID";

            cboVacante.DataSource = _vacanteServicio.ObtenerVacantes();
            cboVacante.DisplayMember = "Titulo";
            cboVacante.ValueMember = "VacanteID";

            cboDecision.Items.Add("Contratado");
            cboDecision.Items.Add("Rechazado");
            cboDecision.Items.Add("En espera");
            cboDecision.SelectedIndex = 0;
        }

        private void CargarDecisiones()
        {
            dgvDecisiones.DataSource = _servicio.ObtenerDecisiones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCandidato.SelectedValue == null || cboVacante.SelectedValue == null)
                {
                    MessageBox.Show("Selecciona candidato y vacante.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _servicio.RegistrarDecision(
                    (int)cboCandidato.SelectedValue,
                    (int)cboVacante.SelectedValue,
                    cboDecision.SelectedItem.ToString(),
                    txtComentario.Text
                );

                MessageBox.Show("Decision guardada exitosamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDecisiones();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDecisiones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una decision para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvDecisiones.SelectedRows[0].Cells["DecisionID"].Value;
            DialogResult confirm = MessageBox.Show("Estas segura de eliminar esta decision?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _servicio.EliminarDecision(id);
                CargarDecisiones();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtComentario.Clear();
            cboDecision.SelectedIndex = 0;
            txtComentario.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboVacante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDecision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblVacante_Click(object sender, EventArgs e)
        {

        }

        private void lblDecision_Click(object sender, EventArgs e)
        {

        }

        // Genera el PDF de la decision final seleccionada, con el CV embebido si existe
        private async void btnImprimirDecision_Click(object sender, EventArgs e)
        {
            if (dgvDecisiones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una decision para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int decisionId = (int)dgvDecisiones.SelectedRows[0].Cells["DecisionID"].Value;
                int candidatoId = (int)dgvDecisiones.SelectedRows[0].Cells["CandidatoID"].Value;
                int vacanteId = (int)dgvDecisiones.SelectedRows[0].Cells["VacanteID"].Value;

                DecisionFinal decision = _servicio.ObtenerDecisiones()
                    .FirstOrDefault(d => d.DecisionID == decisionId);
                Candidato candidato = _candidatoServicio.ObtenerCandidatos()
                    .FirstOrDefault(c => c.CandidatoID == candidatoId);
                Vacante vacante = _vacanteServicio.ObtenerVacantes()
                    .FirstOrDefault(v => v.VacanteID == vacanteId);

                if (decision == null || candidato == null || vacante == null)
                {
                    MessageBox.Show("No se pudo encontrar toda la informacion necesaria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] cvBytes = await _candidatoServicio.ObtenerCVAsync(candidatoId);

                byte[] logoBytes = null;
                using (var ms = new MemoryStream())
                {
                    Properties.Resources.logosr.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    logoBytes = ms.ToArray();
                }

                byte[] pdfFinal = _reporteServicio.GenerarReporteDecisionFinal(decision, candidato, vacante, cvBytes, logoBytes);

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
                    sfd.FileName = $"DecisionFinal_{candidato.Nombre}.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(sfd.FileName, pdfFinal);
                        MessageBox.Show("PDF generado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}