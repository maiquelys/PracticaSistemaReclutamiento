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
            btnVolver = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvVacantes = new DataGridView();
            menuStrip1 = new MenuStrip();
            candidatosToolStripMenuItem = new ToolStripMenuItem();
            vacantesToolStripMenuItem = new ToolStripMenuItem();
            entrevistasToolStripMenuItem = new ToolStripMenuItem();
            decisiónFinalToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVacantes).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpDatos.Controls.Add(cboEstado);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(txtDepartamento);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(txtDescripcion);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(txtTitulo);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDatos.Location = new Point(10, 27);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(760, 180);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de la Vacante";
            // 
            // cboEstado
            // 
            cboEstado.BackColor = SystemColors.InactiveCaption;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activa", "Cerrada", "En proceso" });
            cboEstado.Location = new Point(131, 135);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(150, 28);
            cboEstado.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 135);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 6;
            label4.Text = "Estado:";
            // 
            // txtDepartamento
            // 
            txtDepartamento.BackColor = SystemColors.InactiveCaption;
            txtDepartamento.Location = new Point(131, 100);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(555, 27);
            txtDepartamento.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 100);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 4;
            label3.Text = "Departamento:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.InactiveCaption;
            txtDescripcion.Location = new Point(131, 63);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(555, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 66);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "Descripcion:";
            label2.Click += label2_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = SystemColors.InactiveCaption;
            txtTitulo.Location = new Point(131, 30);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(555, 27);
            txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            label1.Click += label1_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(676, 419);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "← Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 192);
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(141, 213);
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
            btnEliminar.Location = new Point(327, 213);
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
            btnLimpiar.Location = new Point(512, 213);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 35);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvVacantes
            // 
            dgvVacantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVacantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVacantes.Location = new Point(10, 250);
            dgvVacantes.Name = "dgvVacantes";
            dgvVacantes.RowHeadersWidth = 51;
            dgvVacantes.Size = new Size(760, 163);
            dgvVacantes.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { candidatosToolStripMenuItem, vacantesToolStripMenuItem, entrevistasToolStripMenuItem, decisiónFinalToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(146, -4);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(477, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // candidatosToolStripMenuItem
            // 
            candidatosToolStripMenuItem.Name = "candidatosToolStripMenuItem";
            candidatosToolStripMenuItem.Size = new Size(98, 24);
            candidatosToolStripMenuItem.Text = "Candidatos";
            candidatosToolStripMenuItem.Click += candidatosToolStripMenuItem_Click;
            // 
            // vacantesToolStripMenuItem
            // 
            vacantesToolStripMenuItem.Name = "vacantesToolStripMenuItem";
            vacantesToolStripMenuItem.Size = new Size(81, 24);
            vacantesToolStripMenuItem.Text = "Vacantes";
            // 
            // entrevistasToolStripMenuItem
            // 
            entrevistasToolStripMenuItem.Name = "entrevistasToolStripMenuItem";
            entrevistasToolStripMenuItem.Size = new Size(93, 24);
            entrevistasToolStripMenuItem.Text = "Entrevistas";
            entrevistasToolStripMenuItem.Click += entrevistasToolStripMenuItem_Click;
            // 
            // decisiónFinalToolStripMenuItem
            // 
            decisiónFinalToolStripMenuItem.Name = "decisiónFinalToolStripMenuItem";
            decisiónFinalToolStripMenuItem.Size = new Size(115, 24);
            decisiónFinalToolStripMenuItem.Text = "Decisión Final";
            decisiónFinalToolStripMenuItem.Click += decisionFinalToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // frmVacantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(782, 453);
            Controls.Add(btnVolver);
            Controls.Add(dgvVacantes);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(grpDatos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmVacantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Vacantes";
            Load += frmVacantes_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVacantes).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem candidatosToolStripMenuItem;
        private ToolStripMenuItem vacantesToolStripMenuItem;
        private ToolStripMenuItem entrevistasToolStripMenuItem;
        private ToolStripMenuItem decisiónFinalToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
    }
}