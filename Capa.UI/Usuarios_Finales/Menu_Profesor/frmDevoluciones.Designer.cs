namespace Capa.UI.Usuarios_Finales.Menu_Profesor
{
    partial class frmDevoluciones
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
            this.tbpRealizarDevolucion = new System.Windows.Forms.TabPage();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlFaltaLibro = new System.Windows.Forms.Panel();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.mskCodigoLibro = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mskCodigoprestamo = new System.Windows.Forms.MaskedTextBox();
            this.lstLibrosPrestamo = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgSolicitudes_Devol = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaEs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autoriazado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpRealizarDevolucion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolicitudes_Devol)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpRealizarDevolucion
            // 
            this.tbpRealizarDevolucion.Controls.Add(this.btnAceptar);
            this.tbpRealizarDevolucion.Controls.Add(this.pnlFaltaLibro);
            this.tbpRealizarDevolucion.Controls.Add(this.lstLibros);
            this.tbpRealizarDevolucion.Controls.Add(this.groupBox2);
            this.tbpRealizarDevolucion.Controls.Add(this.groupBox1);
            this.tbpRealizarDevolucion.Controls.Add(this.lstLibrosPrestamo);
            this.tbpRealizarDevolucion.Location = new System.Drawing.Point(4, 25);
            this.tbpRealizarDevolucion.Name = "tbpRealizarDevolucion";
            this.tbpRealizarDevolucion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRealizarDevolucion.Size = new System.Drawing.Size(565, 355);
            this.tbpRealizarDevolucion.TabIndex = 0;
            this.tbpRealizarDevolucion.Text = "Realizar Devolución";
            this.tbpRealizarDevolucion.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Capa.UI.Properties.Resources.check;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.Location = new System.Drawing.Point(455, 173);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 68);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnlFaltaLibro
            // 
            this.pnlFaltaLibro.BackgroundImage = global::Capa.UI.Properties.Resources.help481;
            this.pnlFaltaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlFaltaLibro.Location = new System.Drawing.Point(455, 173);
            this.pnlFaltaLibro.Name = "pnlFaltaLibro";
            this.pnlFaltaLibro.Size = new System.Drawing.Size(78, 68);
            this.pnlFaltaLibro.TabIndex = 8;
            this.pnlFaltaLibro.Visible = false;
            this.pnlFaltaLibro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFaltaLibro_Paint);
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.ItemHeight = 16;
            this.lstLibros.Location = new System.Drawing.Point(237, 173);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(208, 164);
            this.lstLibros.TabIndex = 6;
            this.lstLibros.DoubleClick += new System.EventHandler(this.lstLibros_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarLibro);
            this.groupBox2.Controls.Add(this.txtTitulo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnBuscarLibro);
            this.groupBox2.Controls.Add(this.mskCodigoLibro);
            this.groupBox2.Location = new System.Drawing.Point(237, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 139);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Libros Prestados";
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.Enabled = false;
            this.btnAgregarLibro.Location = new System.Drawing.Point(150, 85);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(127, 38);
            this.btnAgregarLibro.TabIndex = 6;
            this.btnAgregarLibro.Text = "Agregar Libro";
            this.btnAgregarLibro.UseVisualStyleBackColor = true;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(18, 93);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(126, 22);
            this.txtTitulo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo:";
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Enabled = false;
            this.btnBuscarLibro.Location = new System.Drawing.Point(151, 21);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(127, 38);
            this.btnBuscarLibro.TabIndex = 1;
            this.btnBuscarLibro.Text = "Buscar Libro";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // mskCodigoLibro
            // 
            this.mskCodigoLibro.Location = new System.Drawing.Point(76, 37);
            this.mskCodigoLibro.Mask = "999999";
            this.mskCodigoLibro.Name = "mskCodigoLibro";
            this.mskCodigoLibro.Size = new System.Drawing.Size(50, 22);
            this.mskCodigoLibro.TabIndex = 2;
            this.mskCodigoLibro.TextChanged += new System.EventHandler(this.mskCodigoLibro_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.mskCodigoprestamo);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Prestamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(18, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 38);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Prestamo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mskCodigoprestamo
            // 
            this.mskCodigoprestamo.Location = new System.Drawing.Point(76, 37);
            this.mskCodigoprestamo.Mask = "999999";
            this.mskCodigoprestamo.Name = "mskCodigoprestamo";
            this.mskCodigoprestamo.Size = new System.Drawing.Size(50, 22);
            this.mskCodigoprestamo.TabIndex = 2;
            this.mskCodigoprestamo.TextChanged += new System.EventHandler(this.mskCodigoprestamo_TextChanged);
            // 
            // lstLibrosPrestamo
            // 
            this.lstLibrosPrestamo.FormattingEnabled = true;
            this.lstLibrosPrestamo.ItemHeight = 16;
            this.lstLibrosPrestamo.Location = new System.Drawing.Point(8, 173);
            this.lstLibrosPrestamo.Name = "lstLibrosPrestamo";
            this.lstLibrosPrestamo.Size = new System.Drawing.Size(208, 164);
            this.lstLibrosPrestamo.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpRealizarDevolucion);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(573, 384);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgSolicitudes_Devol);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(565, 355);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Solicitudes de Devolución";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgSolicitudes_Devol
            // 
            this.dtgSolicitudes_Devol.AllowUserToAddRows = false;
            this.dtgSolicitudes_Devol.AllowUserToDeleteRows = false;
            this.dtgSolicitudes_Devol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSolicitudes_Devol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSolicitudes_Devol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CedulaEs,
            this.FechaDevo,
            this.Autoriazado,
            this.horas,
            this.dias,
            this.fechaa,
            this.minu,
            this.categoria});
            this.dtgSolicitudes_Devol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSolicitudes_Devol.Location = new System.Drawing.Point(3, 3);
            this.dtgSolicitudes_Devol.MultiSelect = false;
            this.dtgSolicitudes_Devol.Name = "dtgSolicitudes_Devol";
            this.dtgSolicitudes_Devol.ReadOnly = true;
            this.dtgSolicitudes_Devol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSolicitudes_Devol.Size = new System.Drawing.Size(559, 349);
            this.dtgSolicitudes_Devol.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "id";
            this.Codigo.FillWeight = 83.96904F;
            this.Codigo.HeaderText = "Prestamo #";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // CedulaEs
            // 
            this.CedulaEs.DataPropertyName = "estudiant";
            this.CedulaEs.FillWeight = 103.5426F;
            this.CedulaEs.HeaderText = "Estudiante";
            this.CedulaEs.Name = "CedulaEs";
            this.CedulaEs.ReadOnly = true;
            // 
            // FechaDevo
            // 
            this.FechaDevo.DataPropertyName = "fecha_Dev";
            this.FechaDevo.FillWeight = 110.9655F;
            this.FechaDevo.HeaderText = "Fecha Devolucion";
            this.FechaDevo.Name = "FechaDevo";
            this.FechaDevo.ReadOnly = true;
            // 
            // Autoriazado
            // 
            this.Autoriazado.DataPropertyName = "USUARIO";
            this.Autoriazado.FillWeight = 101.5228F;
            this.Autoriazado.HeaderText = "Prestado por";
            this.Autoriazado.Name = "Autoriazado";
            this.Autoriazado.ReadOnly = true;
            // 
            // horas
            // 
            this.horas.DataPropertyName = "horas";
            this.horas.HeaderText = "horas";
            this.horas.Name = "horas";
            this.horas.ReadOnly = true;
            this.horas.Visible = false;
            // 
            // dias
            // 
            this.dias.DataPropertyName = "dias";
            this.dias.HeaderText = "Dias";
            this.dias.Name = "dias";
            this.dias.ReadOnly = true;
            this.dias.Visible = false;
            // 
            // fechaa
            // 
            this.fechaa.DataPropertyName = "fecha_act";
            this.fechaa.HeaderText = "Fecha A";
            this.fechaa.Name = "fechaa";
            this.fechaa.ReadOnly = true;
            this.fechaa.Visible = false;
            // 
            // minu
            // 
            this.minu.DataPropertyName = "minutos";
            this.minu.HeaderText = "muni";
            this.minu.Name = "minu";
            this.minu.ReadOnly = true;
            this.minu.Visible = false;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "Categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Visible = false;
            // 
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 384);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.frmDevoluciones_Load);
            this.tbpRealizarDevolucion.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolicitudes_Devol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpRealizarDevolucion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pnlFaltaLibro;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.MaskedTextBox mskCodigoLibro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mskCodigoprestamo;
        private System.Windows.Forms.ListBox lstLibrosPrestamo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgSolicitudes_Devol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaEs;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autoriazado;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn minu;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
    }
}