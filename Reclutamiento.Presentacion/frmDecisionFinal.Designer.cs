namespace Reclutamiento.Presentacion
{
    partial class frmDecisionFinal
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
            lblDecision = new Label();
            cboDecision = new ComboBox();
            lblComentario = new Label();
            txtComentario = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvDecisiones = new DataGridView();
            btnVolver = new Button();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDecisiones).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpDatos.Controls.Add(lblCandidato);
            grpDatos.Controls.Add(cboCandidato);
            grpDatos.Controls.Add(lblVacante);
            grpDatos.Controls.Add(cboVacante);
            grpDatos.Controls.Add(lblDecision);
            grpDatos.Controls.Add(cboDecision);
            grpDatos.Controls.Add(lblComentario);
            grpDatos.Controls.Add(txtComentario);
            grpDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDatos.Location = new Point(10, 10);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(760, 180);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Decision Final";
            // 
            // lblCandidato
            // 
            lblCandidato.AutoSize = true;
            lblCandidato.Location = new Point(32, 30);
            lblCandidato.Name = "lblCandidato";
            lblCandidato.Size = new Size(84, 20);
            lblCandidato.TabIndex = 0;
            lblCandidato.Text = "Candidato:";
            // 
            // cboCandidato
            // 
            cboCandidato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCandidato.Location = new Point(122, 22);
            cboCandidato.Name = "cboCandidato";
            cboCandidato.Size = new Size(250, 28);
            cboCandidato.TabIndex = 1;
            // 
            // lblVacante
            // 
            lblVacante.AutoSize = true;
            lblVacante.Location = new Point(408, 50);
            lblVacante.Name = "lblVacante";
            lblVacante.Size = new Size(68, 20);
            lblVacante.TabIndex = 2;
            lblVacante.Text = "Vacante:";
            lblVacante.Click += lblVacante_Click;
            // 
            // cboVacante
            // 
            cboVacante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVacante.Location = new Point(482, 47);
            cboVacante.Name = "cboVacante";
            cboVacante.Size = new Size(250, 28);
            cboVacante.TabIndex = 3;
            cboVacante.SelectedIndexChanged += cboVacante_SelectedIndexChanged;
            // 
            // lblDecision
            // 
            lblDecision.AutoSize = true;
            lblDecision.Location = new Point(44, 68);
            lblDecision.Name = "lblDecision";
            lblDecision.Size = new Size(72, 20);
            lblDecision.TabIndex = 4;
            lblDecision.Text = "Decision:";
            lblDecision.Click += lblDecision_Click;
            // 
            // cboDecision
            // 
            cboDecision.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDecision.Location = new Point(122, 65);
            cboDecision.Name = "cboDecision";
            cboDecision.Size = new Size(250, 28);
            cboDecision.TabIndex = 5;
            cboDecision.SelectedIndexChanged += cboDecision_SelectedIndexChanged;
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Location = new Point(10, 135);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(95, 20);
            lblComentario.TabIndex = 6;
            lblComentario.Text = "Comentario:";
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(122, 132);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(599, 27);
            txtComentario.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 192);
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(132, 196);
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
            btnEliminar.Location = new Point(339, 196);
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
            btnLimpiar.Location = new Point(535, 196);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 35);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvDecisiones
            // 
            dgvDecisiones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDecisiones.ColumnHeadersHeight = 29;
            dgvDecisiones.Location = new Point(10, 245);
            dgvDecisiones.Name = "dgvDecisiones";
            dgvDecisiones.RowHeadersWidth = 51;
            dgvDecisiones.Size = new Size(760, 200);
            dgvDecisiones.TabIndex = 4;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(676, 468);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "← Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmDecisionFinal
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
            Controls.Add(dgvDecisiones);
            Name = "frmDecisionFinal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Decision Final";
            WindowState = FormWindowState.Minimized;
            Load += frmDecisionFinal_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDecisiones).EndInit();
            ResumeLayout(false);
        }

        private GroupBox grpDatos;
        private Label lblCandidato;
        private ComboBox cboCandidato;
        private Label lblVacante;
        private ComboBox cboVacante;
        private Label lblDecision;
        private ComboBox cboDecision;
        private Label lblComentario;
        private TextBox txtComentario;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvDecisiones;
        private Button btnVolver;
    }
}