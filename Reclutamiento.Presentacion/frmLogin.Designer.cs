namespace Reclutamiento.Presentacion
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // label1
            label1.AutoSize = true;
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Reclutamiento";
            // label2
            label2.AutoSize = true;
            label2.Location = new Point(74, 100);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // txtUsuario
            txtUsuario.Location = new Point(142, 93);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 2;
            // label3
            label3.AutoSize = true;
            label3.Location = new Point(50, 142);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // txtPassword
            txtPassword.Location = new Point(142, 139);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 4;
            txtPassword.PasswordChar = '*';
            // btnLogin
            btnLogin.Location = new Point(126, 195);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.BackColor = Color.DarkBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // frmLogin
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Reclutamiento - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
