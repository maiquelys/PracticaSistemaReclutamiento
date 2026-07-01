using System;
using System.Windows.Forms;
using Reclutamiento.Negocio;
using Reclutamiento.Datos;

namespace Reclutamiento.Presentacion
{
    public partial class frmEntrevistas : Form
    {
        private EntrevistaServicio _servicio = new EntrevistaServicio();
        private CandidatoServicio _candidatoServicio = new CandidatoServicio();
        private VacanteServicio _vacanteServicio = new VacanteServicio();

        public frmEntrevistas()
        {
            InitializeComponent();
        }

        private void frmEntrevistas_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarEntrevistas();
        }

        private void CargarCombos()
        {
            // cargar candidatos en combo
            cboCandidato.DataSource = _candidatoServicio.ObtenerCandidatos();
            cboCandidato.DisplayMember = "Nombre";
            cboCandidato.ValueMember = "CandidatoID";

            // cargar vacantes en combo
            cboVacante.DataSource = _vacanteServicio.ObtenerVacantes();
            cboVacante.DisplayMember = "Titulo";
            cboVacante.ValueMember = "VacanteID";

            // cargar etapas
            cboEtapa.Items.Add("Entrevista inicial");
            cboEtapa.Items.Add("Prueba tecnica");
            cboEtapa.Items.Add("Entrevista final");
            cboEtapa.SelectedIndex = 0;
        }

        private void CargarEntrevistas()
        {
            dgvEntrevistas.DataSource = _servicio.ObtenerEntrevistas();
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

                if (!decimal.TryParse(txtPuntuacion.Text, out decimal puntuacion))
                {
                    MessageBox.Show("La puntuacion debe ser un numero.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _servicio.RegistrarEntrevista(
                    (int)cboCandidato.SelectedValue,
                    (int)cboVacante.SelectedValue,
                    cboEtapa.SelectedIndex + 1,
                    puntuacion
                );

                MessageBox.Show("Entrevista guardada exitosamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEntrevistas();
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
            if (dgvEntrevistas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una entrevista para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvEntrevistas.SelectedRows[0].Cells["EntrevistaID"].Value;
            DialogResult confirm = MessageBox.Show("Estas segura de eliminar esta entrevista?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _servicio.EliminarEntrevista(id);
                CargarEntrevistas();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtPuntuacion.Clear();
            cboEtapa.SelectedIndex = 0;
            txtPuntuacion.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPuntuacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCandidato_Click(object sender, EventArgs e)
        {

        }
    }
}