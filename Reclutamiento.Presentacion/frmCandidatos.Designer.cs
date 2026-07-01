namespace Reclutamiento.Presentacion
{
    partial class frmCandidatos
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
            grpDatos = new GroupBox();
            label1 = new Label();
            txtCedula = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            chkEsInterno = new CheckBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvCandidatos = new DataGridView();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidatos).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(chkEsInterno);
            grpDatos.Controls.Add(txtTelefono);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(txtEmail);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(txtCedula);
            grpDatos.Controls.Add(label1);
            grpDatos.Location = new Point(10, 10);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(400, 220);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Candidato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cedula";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(100, 27);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(200, 27);
            txtCedula.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 65);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 100);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 135);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(100, 132);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 27);
            txtTelefono.TabIndex = 7;
            // 
            // chkEsInterno
            // 
            chkEsInterno.AutoSize = true;
            chkEsInterno.Location = new Point(100, 170);
            chkEsInterno.Name = "chkEsInterno";
            chkEsInterno.Size = new Size(96, 24);
            chkEsInterno.TabIndex = 8;
            chkEsInterno.Text = "Es Interno";
            chkEsInterno.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(10, 240);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 35);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(120, 240);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(230, 240);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 35);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvCandidatos
            // 
            dgvCandidatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCandidatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCandidatos.Location = new Point(10, 290);
            dgvCandidatos.Name = "dgvCandidatos";
            dgvCandidatos.RowHeadersWidth = 51;
            dgvCandidatos.Size = new Size(760, 150);
            dgvCandidatos.TabIndex = 4;
            // 
            // frmCandidatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(dgvCandidatos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(grpDatos);
            Name = "frmCandidatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Candidatos";
            WindowState = FormWindowState.Maximized;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private Label label2;
        private TextBox txtCedula;
        private Label label1;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtEmail;
        private CheckBox chkEsInterno;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvCandidatos;
    }
}