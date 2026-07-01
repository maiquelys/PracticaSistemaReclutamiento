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
            label1 = new Label();
            btnCandidatos = new Button();
            btnVacantes = new Button();
            btnEntrevista = new Button();
            btnCerrarSesion = new Button();
            btnDecision = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 58);
            label1.Name = "label1";
            label1.Size = new Size(427, 31);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Gestion de Reclutamiento";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCandidatos
            // 
            btnCandidatos.Anchor = AnchorStyles.None;
            btnCandidatos.BackColor = Color.CornflowerBlue;
            btnCandidatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCandidatos.Location = new Point(39, 150);
            btnCandidatos.Name = "btnCandidatos";
            btnCandidatos.Size = new Size(154, 133);
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
            btnVacantes.Location = new Point(223, 150);
            btnVacantes.Name = "btnVacantes";
            btnVacantes.Size = new Size(154, 133);
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
            btnEntrevista.Location = new Point(410, 150);
            btnEntrevista.Name = "btnEntrevista";
            btnEntrevista.Size = new Size(154, 133);
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
            btnCerrarSesion.Location = new Point(289, 350);
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
            btnDecision.Location = new Point(596, 150);
            btnDecision.Name = "btnDecision";
            btnDecision.Size = new Size(154, 133);
            btnDecision.TabIndex = 5;
            btnDecision.Text = "Decision Final";
            btnDecision.UseVisualStyleBackColor = false;
            btnDecision.Click += btnDecision_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(782, 453);
            Controls.Add(btnDecision);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEntrevista);
            Controls.Add(btnVacantes);
            Controls.Add(btnCandidatos);
            Controls.Add(label1);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Reclutamiento";
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
    }
}