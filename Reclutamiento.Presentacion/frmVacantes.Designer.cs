namespace Reclutamiento.Presentacion
{
    partial class frmVacantes
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
            cboEstado = new ComboBox();
            label4 = new Label();
            txtDepartamento = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtTitulo = new TextBox();
            label1 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvVacantes = new DataGridView();
            btnVolver = new Button();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVacantes).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpDatos.Controls.Add(btnVolver);
            grpDatos.Controls.Add(cboEstado);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(txtDepartamento);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(txtDescripcion);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(txtTitulo);
            grpDatos.Controls.Add(label1);
            grpDatos.Location = new Point(10, 10);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(760, 180);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de la Vacante";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activa", "Cerrada", "En proceso" });
            cboEstado.Location = new Point(100, 132);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(150, 28);
            cboEstado.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 135);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 6;
            label4.Text = "Estado:";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(100, 97);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(300, 27);
            txtDepartamento.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 100);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 4;
            label3.Text = "Departamento:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(100, 62);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(300, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 65);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "Descripcion:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(100, 27);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(300, 27);
            txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(10, 200);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 35);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(120, 200);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(230, 200);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 35);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvVacantes
            // 
            dgvVacantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVacantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVacantes.Location = new Point(10, 250);
            dgvVacantes.Name = "dgvVacantes";
            dgvVacantes.RowHeadersWidth = 51;
            dgvVacantes.Size = new Size(760, 180);
            dgvVacantes.TabIndex = 4;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(478, 135);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "← Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmVacantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(dgvVacantes);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(grpDatos);
            Name = "frmVacantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Vacantes";
            WindowState = FormWindowState.Maximized;
            Load += frmVacantes_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVacantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private Label label2;
        private TextBox txtTitulo;
        private Label label1;
        private ComboBox cboEstado;
        private Label label4;
        private TextBox txtDepartamento;
        private Label label3;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvVacantes;
        private Button btnVolver;
    }
}