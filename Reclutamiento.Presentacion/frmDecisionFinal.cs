using System;
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

        public frmDecisionFinal()
        {
            InitializeComponent();
        }

        private void frmDecisionFinal_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarDecisiones();
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
    }
}