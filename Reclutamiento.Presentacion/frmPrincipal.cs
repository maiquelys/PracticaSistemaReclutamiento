using System;
using System.Windows.Forms;

namespace Reclutamiento.Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void btnCandidatos_Click(object sender, EventArgs e)
        {
            frmCandidatos frm = new frmCandidatos();
            frm.Show();
        }
        private void btnVacantes_Click(object sender, EventArgs e)
        {
            try
            {
                frmVacantes frm = new frmVacantes();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnEntrevistas_Click(object sender, EventArgs e)
        {
            frmEntrevistas frm = new frmEntrevistas();
            frm.Show();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void btnEntrevista_Click(object sender, EventArgs e)
        {

        }
    }
}