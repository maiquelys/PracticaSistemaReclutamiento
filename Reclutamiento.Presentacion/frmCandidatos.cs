using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                try
                {
                    _servicio.EliminarCandidato(id);
                    CargarCandidatos();
                }
                catch (Microsoft.Data.SqlClient.SqlException ex) when (ex.Number == 547)
                {
                    MessageBox.Show("No se puede eliminar este candidato porque tiene entrevistas registradas asociadas. Elimina primero esas entrevistas.", "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            candidatosToolStripMenuItem.Font = new Font(candidatosToolStripMenuItem.Font, FontStyle.Bold);
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

        private async void btnSubirCV_Click(object sender, EventArgs e)
        {
            if (dgvCandidatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un candidato para subirle el CV.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvCandidatos.SelectedRows[0].Cells["CandidatoID"].Value;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos PDF (*.pdf)|*.pdf";
                ofd.Title = "Selecciona el CV en PDF";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] cvBytes = File.ReadAllBytes(ofd.FileName);
                        await _servicio.SubirCVAsync(id, cvBytes);
                        MessageBox.Show("CV subido exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al subir el CV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnVerCV_Click(object sender, EventArgs e)
        {
            if (dgvCandidatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un candidato para ver su CV.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvCandidatos.SelectedRows[0].Cells["CandidatoID"].Value;

            try
            {
                byte[] cvBytes = await _servicio.ObtenerCVAsync(id);

                if (cvBytes == null)
                {
                    MessageBox.Show("Este candidato no tiene un CV guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string rutaTemp = Path.Combine(Path.GetTempPath(), $"CV_{id}.pdf");
                File.WriteAllBytes(rutaTemp, cvBytes);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = rutaTemp,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el CV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vacantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVacantes frm = new frmVacantes();
            frm.ShowDialog();
            this.Show();
        }
        private void entrevistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEntrevistas frm = new frmEntrevistas();
            frm.ShowDialog();
            this.Show();
        }
        private void decisionFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDecisionFinal frm = new frmDecisionFinal();
            frm.ShowDialog();
            this.Show();
        }
        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReportes frm = new frmReportes();
            frm.ShowDialog();
            this.Show();
        }

        private void decToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void decToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}