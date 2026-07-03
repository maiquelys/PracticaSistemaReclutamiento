namespace Reclutamiento.Presentacion
{
    partial class frmReportes
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
            lblTitulo = new Label();
            btnCandidatosInternos = new Button();
            btnCandidatosExternos = new Button();
            btnVacantesActivas = new Button();
            btnEntrevistasAltas = new Button();
            dgvReporte = new DataGridView();
            lblResultado = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(760, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reportes";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnCandidatosInternos
            // 
            btnCandidatosInternos.BackColor = Color.DarkBlue;
            btnCandidatosInternos.ForeColor = Color.White;
            btnCandidatosInternos.Location = new Point(10, 60);
            btnCandidatosInternos.Name = "btnCandidatosInternos";
            btnCandidatosInternos.Size = new Size(180, 50);
            btnCandidatosInternos.TabIndex = 1;
            btnCandidatosInternos.Text = "Candidatos Internos";
            btnCandidatosInternos.UseVisualStyleBackColor = false;
            btnCandidatosInternos.Click += btnCandidatosInternos_Click;
            // 
            // btnCandidatosExternos
            // 
            btnCandidatosExternos.BackColor = Color.DarkGreen;
            btnCandidatosExternos.ForeColor = Color.White;
            btnCandidatosExternos.Location = new Point(200, 60);
            btnCandidatosExternos.Name = "btnCandidatosExternos";
            btnCandidatosExternos.Size = new Size(180, 50);
            btnCandidatosExternos.TabIndex = 2;
            btnCandidatosExternos.Text = "Candidatos Externos";
            btnCandidatosExternos.UseVisualStyleBackColor = false;
            btnCandidatosExternos.Click += btnCandidatosExternos_Click;
            // 
            // btnVacantesActivas
            // 
            btnVacantesActivas.BackColor = Color.DarkRed;
            btnVacantesActivas.ForeColor = Color.White;
            btnVacantesActivas.Location = new Point(390, 60);
            btnVacantesActivas.Name = "btnVacantesActivas";
            btnVacantesActivas.Size = new Size(180, 50);
            btnVacantesActivas.TabIndex = 3;
            btnVacantesActivas.Text = "Vacantes Activas";
            btnVacantesActivas.UseVisualStyleBackColor = false;
            btnVacantesActivas.Click += btnVacantesActivas_Click;
            // 
            // btnEntrevistasAltas
            // 
            btnEntrevistasAltas.BackColor = Color.DarkOrange;
            btnEntrevistasAltas.ForeColor = Color.White;
            btnEntrevistasAltas.Location = new Point(580, 60);
            btnEntrevistasAltas.Name = "btnEntrevistasAltas";
            btnEntrevistasAltas.Size = new Size(180, 50);
            btnEntrevistasAltas.TabIndex = 4;
            btnEntrevistasAltas.Text = "Entrevistas Puntuacion Alta";
            btnEntrevistasAltas.UseVisualStyleBackColor = false;
            btnEntrevistasAltas.Click += btnEntrevistasAltas_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReporte.ColumnHeadersHeight = 29;
            dgvReporte.Location = new Point(10, 150);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(760, 280);
            dgvReporte.TabIndex = 6;
            // 
            // lblResultado
            // 
            lblResultado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblResultado.Location = new Point(10, 120);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(760, 25);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Selecciona un reporte para ver los resultados.";
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVolver.Location = new Point(650, 10);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 30);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "<- Volver";
            btnVolver.Click += btnVolver_Click;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 500);
            Controls.Add(lblTitulo);
            Controls.Add(btnCandidatosInternos);
            Controls.Add(btnCandidatosExternos);
            Controls.Add(btnVacantesActivas);
            Controls.Add(btnEntrevistasAltas);
            Controls.Add(lblResultado);
            Controls.Add(dgvReporte);
            Controls.Add(btnVolver);
            Name = "frmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
        }

        private Label lblTitulo;
        private Button btnCandidatosInternos;
        private Button btnCandidatosExternos;
        private Button btnVacantesActivas;
        private Button btnEntrevistasAltas;
        private Label lblResultado;
        private DataGridView dgvReporte;
        private Button btnVolver;
    }
}