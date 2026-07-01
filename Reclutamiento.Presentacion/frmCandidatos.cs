using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Reclutamiento.Negocio;
using Reclutamiento.Datos;

namespace Reclutamiento.Presentacion
{
    public partial class frmCandidatos : Form
    {
        private CandidatoServicio _servicio = new CandidatoServicio();
        public frmCandidatos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _servicio.RegistrarCandidato(
                    txtCedula.Text,
                    txtNombre.Text,
                    txtEmail.Text,
                    txtTelefono.Text,
                    chkEsInterno.Checked
                    );
                MessageBox.Show("Candidato guardado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCandidatos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCandidatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un candidato para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = (int)dgvCandidatos.SelectedRows[0].Cells["CandidatoID"].Value;
            DialogResult confirm = MessageBox.Show("Estas segura de eliminar este candidato?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _servicio.EliminarCandidato(id);
                CargarCandidatos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            chkEsInterno.Checked = false;
            txtCedula.Focus();
        }

        private void frmCandidatos_Load(object sender, EventArgs e)
        {
            CargarCandidatos();
        }
        private void CargarCandidatos()
        {
            dgvCandidatos.DataSource = _servicio.ObtenerCandidatos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
