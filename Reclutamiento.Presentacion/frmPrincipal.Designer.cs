namespace Reclutamiento.Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            label1 = new Label();
            btnCandidatos = new Button();
            btnVacantes = new Button();
            btnEntrevista = new Button();
            btnCerrarSesion = new Button();
            btnDecision = new Button();
            btnReportes = new Button();
            menuStrip1 = new MenuStrip();
            candidatosToolStripMenuItem = new ToolStripMenuItem();
            vacantesToolStripMenuItem = new ToolStripMenuItem();
            entrevistasToolStripMenuItem = new ToolStripMenuItem();
            decisionFinalToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 33);
            label1.Name = "label1";
            label1.Size = new Size(438, 90);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Gestion de \r\nReclutamiento";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCandidatos
            // 
            btnCandidatos.Anchor = AnchorStyles.None;
            btnCandidatos.BackColor = Color.CornflowerBlue;
            btnCandidatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCandidatos.Location = new Point(340, 155);
            btnCandidatos.Name = "btnCandidatos";
            btnCandidatos.Size = new Size(125, 105);
            btnCandidatos.TabIndex = 1;
            btnCandidatos.Text = "Candidatos";
            btnCandidatos.UseVisualStyleBackColor = false;
            btnCandidatos.Click += btnCandidatos_Click;
            // 
            // btnVacantes
            // 
            btnVacantes.Anchor = AnchorStyles.None;
            btnVacantes.BackColor = Color.CornflowerBlue;
            btnVacantes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVacantes.Location = new Point(471, 155);
            btnVacantes.Name = "btnVacantes";
            btnVacantes.Size = new Size(125, 105);
            btnVacantes.TabIndex = 2;
            btnVacantes.Text = "Vacantes";
            btnVacantes.UseVisualStyleBackColor = false;
            btnVacantes.Click += btnVacantes_Click;
            // 
            // btnEntrevista
            // 
            btnEntrevista.Anchor = AnchorStyles.None;
            btnEntrevista.BackColor = Color.CornflowerBlue;
            btnEntrevista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrevista.Location = new Point(602, 155);
            btnEntrevista.Name = "btnEntrevista";
            btnEntrevista.Size = new Size(125, 105);
            btnEntrevista.TabIndex = 3;
            btnEntrevista.Text = "Entrevistas";
            btnEntrevista.UseVisualStyleBackColor = false;
            btnEntrevista.Click += btnEntrevistas_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom;
            btnCerrarSesion.BackColor = Color.MidnightBlue;
            btnCerrarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = SystemColors.ButtonHighlight;
            btnCerrarSesion.Location = new Point(455, 401);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(150, 40);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnDecision
            // 
            btnDecision.Anchor = AnchorStyles.None;
            btnDecision.BackColor = Color.CornflowerBlue;
            btnDecision.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecision.Location = new Point(392, 266);
            btnDecision.Name = "btnDecision";
            btnDecision.Size = new Size(125, 105);
            btnDecision.TabIndex = 5;
            btnDecision.Text = "Decision Final";
            btnDecision.UseVisualStyleBackColor = false;
            btnDecision.Click += btnDecision_Click;
            // 
            // btnReportes
            // 
            btnReportes.Anchor = AnchorStyles.None;
            btnReportes.BackColor = Color.CornflowerBlue;
            btnReportes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(523, 266);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(125, 105);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { candidatosToolStripMenuItem, vacantesToolStripMenuItem, entrevistasToolStripMenuItem, decisionFinalToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(146, -4);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(477, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // candidatosToolStripMenuItem
            // 
            candidatosToolStripMenuItem.Name = "candidatosToolStripMenuItem";
            candidatosToolStripMenuItem.Size = new Size(98, 24);
            candidatosToolStripMenuItem.Text = "Candidatos";
            candidatosToolStripMenuItem.Click += btnCandidatos_Click;
            // 
            // vacantesToolStripMenuItem
            // 
            vacantesToolStripMenuItem.Name = "vacantesToolStripMenuItem";
            vacantesToolStripMenuItem.Size = new Size(81, 24);
            vacantesToolStripMenuItem.Text = "Vacantes";
            vacantesToolStripMenuItem.Click += btnVacantes_Click;
            // 
            // entrevistasToolStripMenuItem
            // 
            entrevistasToolStripMenuItem.Name = "entrevistasToolStripMenuItem";
            entrevistasToolStripMenuItem.Size = new Size(93, 24);
            entrevistasToolStripMenuItem.Text = "Entrevistas";
            entrevistasToolStripMenuItem.Click += btnEntrevistas_Click;
            // 
            // decisionFinalToolStripMenuItem
            // 
            decisionFinalToolStripMenuItem.Name = "decisionFinalToolStripMenuItem";
            decisionFinalToolStripMenuItem.Size = new Size(115, 24);
            decisionFinalToolStripMenuItem.Text = "Decision Final";
            decisionFinalToolStripMenuItem.Click += btnDecision_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(782, 453);
            Controls.Add(pictureBox1);
            Controls.Add(btnReportes);
            Controls.Add(btnDecision);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEntrevista);
            Controls.Add(btnVacantes);
            Controls.Add(btnCandidatos);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Reclutamiento";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCandidatos;
        private Button btnVacantes;
        private Button btnEntrevista;
        private Button btnCerrarSesion;
        private Button btnDecision;
        private Button btnReportes;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem candidatosToolStripMenuItem;
        private ToolStripMenuItem vacantesToolStripMenuItem;
        private ToolStripMenuItem entrevistasToolStripMenuItem;
        private ToolStripMenuItem decisionFinalToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}