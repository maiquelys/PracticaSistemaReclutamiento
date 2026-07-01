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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(250, 60);
            label1.Name = "label1";
            label1.Size = new Size(257, 20);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Gestion de Reclutamiento";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCandidatos
            // 
            btnCandidatos.Anchor = AnchorStyles.None;
            btnCandidatos.Location = new Point(39, 150);
            btnCandidatos.Name = "btnCandidatos";
            btnCandidatos.Size = new Size(200, 133);
            btnCandidatos.TabIndex = 1;
            btnCandidatos.Text = "Candidatos";
            btnCandidatos.UseVisualStyleBackColor = true;
            btnCandidatos.Click += btnCandidatos_Click;
            // 
            // btnVacantes
            // 
            btnVacantes.Anchor = AnchorStyles.None;
            btnVacantes.Location = new Point(289, 150);
            btnVacantes.Name = "btnVacantes";
            btnVacantes.Size = new Size(200, 133);
            btnVacantes.TabIndex = 2;
            btnVacantes.Text = "Vacantes";
            btnVacantes.UseVisualStyleBackColor = true;
            btnVacantes.Click += btnVacantes_Click;
            // 
            // btnEntrevista
            // 
            btnEntrevista.Anchor = AnchorStyles.None;
            btnEntrevista.Location = new Point(550, 150);
            btnEntrevista.Name = "btnEntrevista";
            btnEntrevista.Size = new Size(200, 133);
            btnEntrevista.TabIndex = 3;
            btnEntrevista.Text = "Entrevistas";
            btnEntrevista.UseVisualStyleBackColor = true;
            btnEntrevista.Click += btnEntrevista_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom;
            btnCerrarSesion.Location = new Point(289, 350);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(150, 40);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEntrevista);
            Controls.Add(btnVacantes);
            Controls.Add(btnCandidatos);
            Controls.Add(label1);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Reclutamiento";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCandidatos;
        private Button btnVacantes;
        private Button btnEntrevista;
        private Button btnCerrarSesion;
    }
}