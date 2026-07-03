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
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnVacantes_Click(object sender, EventArgs e)
        {
            try
            {
                frmVacantes frm = new frmVacantes();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnEntrevistas_Click(object sender, EventArgs e)
        {
            frmEntrevistas frm = new frmEntrevistas();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnDecision_Click(object sender, EventArgs e)
        {
            frmDecisionFinal frm = new frmDecisionFinal();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}