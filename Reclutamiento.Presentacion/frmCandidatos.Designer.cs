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
            chkEsInterno = new CheckBox();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtCedula = new TextBox();
            label1 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvCandidatos = new DataGridView();
            btnVolver = new Button();
            btnSubirCV = new Button();
            btnVerCV = new Button();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidatos).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Anchor = AnchorStyles.None;
            grpDatos.Controls.Add(chkEsInterno);
            grpDatos.Controls.Add(txtTelefono);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(txtEmail);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(txtCedula);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDatos.Location = new Point(12, 23);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(758, 158);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Candidato";
            // 
            // chkEsInterno
            // 
            chkEsInterno.AutoSize = true;
            chkEsInterno.Location = new Point(338, 134);
            chkEsInterno.Name = "chkEsInterno";
            chkEsInterno.Size = new Size(102, 24);
            chkEsInterno.TabIndex = 8;
            chkEsInterno.Text = "Es Interno";
            chkEsInterno.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.InactiveCaption;
            txtTelefono.Location = new Point(505, 84);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 27);
            txtTelefono.TabIndex = 7;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 84);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 6;
            label4.Text = "Telefono:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveCaption;
            txtEmail.Location = new Point(505, 26);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 30);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            label3.Click += label3_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Location = new Point(138, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 84);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            label2.Click += label2_Click;
            // 
            // txtCedula
            // 
            txtCedula.BackColor = SystemColors.InactiveCaption;
            txtCedula.Location = new Point(138, 30);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(200, 27);
            txtCedula.TabIndex = 1;
            txtCedula.TextChanged += txtCedula_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 33);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Cedula:";
            label1.Click += label1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.FromArgb(192, 255, 192);
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(25, 187);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 35);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(131, 187);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(237, 187);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 35);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvCandidatos
            // 
            dgvCandidatos.Anchor = AnchorStyles.None;
            dgvCandidatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCandidatos.Location = new Point(25, 228);
            dgvCandidatos.Name = "dgvCandidatos";
            dgvCandidatos.RowHeadersWidth = 51;
            dgvCandidatos.Size = new Size(733, 174);
            dgvCandidatos.TabIndex = 4;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVolver.Location = new Point(664, 412);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "← Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSubirCV
            // 
            btnSubirCV.BackColor = Color.DarkGray;
            btnSubirCV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubirCV.ForeColor = Color.RoyalBlue;
            btnSubirCV.Location = new Point(558, 187);
            btnSubirCV.Name = "btnSubirCV";
            btnSubirCV.Size = new Size(100, 35);
            btnSubirCV.TabIndex = 6;
            btnSubirCV.Text = "Subir CV";
            btnSubirCV.UseVisualStyleBackColor = false;
            btnSubirCV.Click += btnSubirCV_Click;
            // 
            // btnVerCV
            // 
            btnVerCV.BackColor = Color.CornflowerBlue;
            btnVerCV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerCV.ForeColor = Color.Black;
            btnVerCV.Location = new Point(664, 187);
            btnVerCV.Name = "btnVerCV";
            btnVerCV.Size = new Size(100, 35);
            btnVerCV.TabIndex = 7;
            btnVerCV.Text = "Ver CV";
            btnVerCV.UseVisualStyleBackColor = false;
            btnVerCV.Click += btnVerCV_Click;
            // 
            // frmCandidatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(782, 453);
            Controls.Add(btnVerCV);
            Controls.Add(btnSubirCV);
            Controls.Add(btnVolver);
            Controls.Add(dgvCandidatos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(grpDatos);
            Name = "frmCandidatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Candidatos";
            Load += frmCandidatos_Load;
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
        private Button btnVolver;
        private Button btnSubirCV;
        private Button btnVerCV;
    }
}