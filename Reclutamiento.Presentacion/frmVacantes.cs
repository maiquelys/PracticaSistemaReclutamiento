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
    public partial class frmVacantes : Form
    {
        private VacanteServicio _servicio = new VacanteServicio();
        public frmVacantes()
        {
            InitializeComponent();
        }

        private void frmVacantes_Load(object sender, EventArgs e)
        {
            CargarVacantes();
            cboEstado.SelectedIndex = 0;
        }
        private void CargarVacantes()
        {
            dgvVacantes.DataSource = _servicio.ObtenerVacantes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _servicio.RegistrarVacante(
                    txtTitulo.Text,
                    txtDescripcion.Text,
                    txtDepartamento.Text
                );
                MessageBox.Show("Vacante guardada exitosamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarVacantes();
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
            if (dgvVacantes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una vacante para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvVacantes.SelectedRows[0].Cells["VacanteID"].Value;
            DialogResult confirm = MessageBox.Show("Estas segura de eliminar esta vacante?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _servicio.EliminarVacante(id);
                CargarVacantes();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            txtDepartamento.Clear();
            cboEstado.SelectedIndex = 0;
            txtTitulo.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
