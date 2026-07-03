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
            btnVolver = new Button();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntrevistas).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpDatos.Controls.Add(lblCandidato);
            grpDatos.Controls.Add(cboCandidato);
            grpDatos.Controls.Add(lblVacante);
            grpDatos.Controls.Add(cboVacante);
            grpDatos.Controls.Add(lblEtapa);
            grpDatos.Controls.Add(cboEtapa);
            grpDatos.Controls.Add(lblPuntuacion);
            grpDatos.Controls.Add(txtPuntuacion);
            grpDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDatos.Location = new Point(10, 10);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(760, 133);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de la Entrevista";
            // 
            // lblCandidato
            // 
            lblCandidato.AutoSize = true;
            lblCandidato.Location = new Point(41, 30);
            lblCandidato.Name = "lblCandidato";
            lblCandidato.Size = new Size(84, 20);
            lblCandidato.TabIndex = 0;
            lblCandidato.Text = "Candidato:";
            lblCandidato.Click += lblCandidato_Click;
            // 
            // cboCandidato
            // 
            cboCandidato.BackColor = SystemColors.InactiveCaption;
            cboCandidato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCandidato.Location = new Point(131, 27);
            cboCandidato.Name = "cboCandidato";
            cboCandidato.Size = new Size(250, 28);
            cboCandidato.TabIndex = 1;
            // 
            // lblVacante
            // 
            lblVacante.AutoSize = true;
            lblVacante.Location = new Point(57, 70);
            lblVacante.Name = "lblVacante";
            lblVacante.Size = new Size(68, 20);
            lblVacante.TabIndex = 2;
            lblVacante.Text = "Vacante:";
            // 
            // cboVacante
            // 
            cboVacante.BackColor = SystemColors.InactiveCaption;
            cboVacante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVacante.Location = new Point(131, 70);
            cboVacante.Name = "cboVacante";
            cboVacante.Size = new Size(250, 28);
            cboVacante.TabIndex = 3;
            // 
            // lblEtapa
            // 
            lblEtapa.AutoSize = true;
            lblEtapa.Location = new Point(429, 30);
            lblEtapa.Name = "lblEtapa";
            lblEtapa.Size = new Size(52, 20);
            lblEtapa.TabIndex = 4;
            lblEtapa.Text = "Etapa:";
            // 
            // cboEtapa
            // 
            cboEtapa.BackColor = SystemColors.InactiveCaption;
            cboEtapa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEtapa.Location = new Point(487, 22);
            cboEtapa.Name = "cboEtapa";
            cboEtapa.Size = new Size(250, 28);
            cboEtapa.TabIndex = 5;
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.AutoSize = true;
            lblPuntuacion.Location = new Point(462, 77);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(92, 20);
            lblPuntuacion.TabIndex = 6;
            lblPuntuacion.Text = "Puntuacion:";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.BackColor = SystemColors.InactiveCaption;
            txtPuntuacion.Location = new Point(560, 70);
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(100, 27);
            txtPuntuacion.TabIndex = 7;
            txtPuntuacion.TextChanged += txtPuntuacion_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 192);
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(109, 149);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 35);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(333, 149);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(570, 149);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 35);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvEntrevistas
            // 
            dgvEntrevistas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEntrevistas.ColumnHeadersHeight = 29;
            dgvEntrevistas.Location = new Point(10, 213);
            dgvEntrevistas.Name = "dgvEntrevistas";
            dgvEntrevistas.RowHeadersWidth = 51;
            dgvEntrevistas.Size = new Size(760, 227);
            dgvEntrevistas.TabIndex = 4;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(676, 459);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "← Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmEntrevistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 500);
            Controls.Add(btnVolver);
            Controls.Add(grpDatos);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvEntrevistas);
            Name = "frmEntrevistas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Entrevistas";
            WindowState = FormWindowState.Minimized;
            Load += frmEntrevistas_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntrevistas).EndInit();
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
        private Button btnVolver;
    }
}