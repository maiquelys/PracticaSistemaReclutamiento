namespace Reclutamiento.Presentacion
{
    partial class frmEntrevistas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpDatos = new GroupBox();
            lblCandidato = new Label();
            cboCandidato = new ComboBox();
            lblVacante = new Label();
            cboVacante = new ComboBox();
            lblEtapa = new Label();
            cboEtapa = new ComboBox();
            lblPuntuacion = new Label();
            txtPuntuacion = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvEntrevistas = new DataGridView();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // grpDatos
            grpDatos.Controls.Add(lblCandidato);
            grpDatos.Controls.Add(cboCandidato);
            grpDatos.Controls.Add(lblVacante);
            grpDatos.Controls.Add(cboVacante);
            grpDatos.Controls.Add(lblEtapa);
            grpDatos.Controls.Add(cboEtapa);
            grpDatos.Controls.Add(lblPuntuacion);
            grpDatos.Controls.Add(txtPuntuacion);
            grpDatos.Location = new Point(10, 10);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(760, 160);
            grpDatos.Text = "Datos de la Entrevista";
            grpDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // lblCandidato
            lblCandidato.Location = new Point(10, 30);
            lblCandidato.Text = "Candidato:";
            lblCandidato.AutoSize = true;
            // cboCandidato
            cboCandidato.Location = new Point(100, 27);
            cboCandidato.Size = new Size(250, 23);
            cboCandidato.Name = "cboCandidato";
            cboCandidato.DropDownStyle = ComboBoxStyle.DropDownList;
            // lblVacante
            lblVacante.Location = new Point(10, 65);
            lblVacante.Text = "Vacante:";
            lblVacante.AutoSize = true;
            // cboVacante
            cboVacante.Location = new Point(100, 62);
            cboVacante.Size = new Size(250, 23);
            cboVacante.Name = "cboVacante";
            cboVacante.DropDownStyle = ComboBoxStyle.DropDownList;
            // lblEtapa
            lblEtapa.Location = new Point(10, 100);
            lblEtapa.Text = "Etapa:";
            lblEtapa.AutoSize = true;
            // cboEtapa
            cboEtapa.Location = new Point(100, 97);
            cboEtapa.Size = new Size(250, 23);
            cboEtapa.Name = "cboEtapa";
            cboEtapa.DropDownStyle = ComboBoxStyle.DropDownList;
            // lblPuntuacion
            lblPuntuacion.Location = new Point(10, 135);
            lblPuntuacion.Text = "Puntuacion:";
            lblPuntuacion.AutoSize = true;
            // txtPuntuacion
            txtPuntuacion.Location = new Point(100, 132);
            txtPuntuacion.Size = new Size(100, 23);
            txtPuntuacion.Name = "txtPuntuacion";
            // btnGuardar
            btnGuardar.Location = new Point(10, 180);
            btnGuardar.Size = new Size(100, 35);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Text = "Guardar";
            btnGuardar.BackColor = Color.DarkBlue;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // btnEliminar
            btnEliminar.Location = new Point(120, 180);
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // btnLimpiar
            btnLimpiar.Location = new Point(230, 180);
            btnLimpiar.Size = new Size(100, 35);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;
            // dgvEntrevistas
            dgvEntrevistas.Location = new Point(10, 225);
            dgvEntrevistas.Size = new Size(760, 200);
            dgvEntrevistas.Name = "dgvEntrevistas";
            dgvEntrevistas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // frmEntrevistas
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(grpDatos);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvEntrevistas);
            Name = "frmEntrevistas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Entrevistas";
            WindowState = FormWindowState.Maximized;
            Load += frmEntrevistas_Load;
            grpDatos.ResumeLayout(false);
            ResumeLayout(false);
        }

        private GroupBox grpDatos;
        private Label lblCandidato;
        private ComboBox cboCandidato;
        private Label lblVacante;
        private ComboBox cboVacante;
        private Label lblEtapa;
        private ComboBox cboEtapa;
        private Label lblPuntuacion;
        private TextBox txtPuntuacion;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvEntrevistas;
    }
}