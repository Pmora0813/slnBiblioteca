namespace Capa.UI.Reportes
{
    partial class frmRep_Libros_Estudiantes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRalizarReporte = new System.Windows.Forms.Button();
            this.lstLibrosPrestamo = new System.Windows.Forms.ListBox();
            this.dtgLibros = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReporteEstudiantes = new System.Windows.Forms.Button();
            this.lstEstudiantes = new System.Windows.Forms.ListBox();
            this.dtgEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnTodosIzquierda = new System.Windows.Forms.Button();
            this.btnTodosDerecha = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarEstudiantes = new System.Windows.Forms.Button();
            this.btnAgregarEstudiantes = new System.Windows.Forms.Button();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.QR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_QR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTodosIzquierda);
            this.tabPage1.Controls.Add(this.btnTodosDerecha);
            this.tabPage1.Controls.Add(this.btnRalizarReporte);
            this.tabPage1.Controls.Add(this.lstLibrosPrestamo);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Controls.Add(this.dtgLibros);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reporte de Libros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRalizarReporte
            // 
            this.btnRalizarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRalizarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRalizarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRalizarReporte.Location = new System.Drawing.Point(233, 232);
            this.btnRalizarReporte.Name = "btnRalizarReporte";
            this.btnRalizarReporte.Size = new System.Drawing.Size(267, 49);
            this.btnRalizarReporte.TabIndex = 19;
            this.btnRalizarReporte.Text = "Reporte de Libros";
            this.btnRalizarReporte.UseVisualStyleBackColor = true;
            this.btnRalizarReporte.Click += new System.EventHandler(this.btnRalizarReporte_Click);
            // 
            // lstLibrosPrestamo
            // 
            this.lstLibrosPrestamo.FormattingEnabled = true;
            this.lstLibrosPrestamo.ItemHeight = 16;
            this.lstLibrosPrestamo.Location = new System.Drawing.Point(415, 23);
            this.lstLibrosPrestamo.Name = "lstLibrosPrestamo";
            this.lstLibrosPrestamo.Size = new System.Drawing.Size(238, 180);
            this.lstLibrosPrestamo.TabIndex = 18;
            // 
            // dtgLibros
            // 
            this.dtgLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Codigod,
            this.Nombre,
            this.id_Editorial,
            this.Anno});
            this.dtgLibros.Location = new System.Drawing.Point(21, 23);
            this.dtgLibros.MultiSelect = false;
            this.dtgLibros.Name = "dtgLibros";
            this.dtgLibros.ReadOnly = true;
            this.dtgLibros.RowTemplate.Height = 24;
            this.dtgLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLibros.Size = new System.Drawing.Size(290, 176);
            this.dtgLibros.TabIndex = 14;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "id";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Codigod
            // 
            this.Codigod.DataPropertyName = "Codigo";
            this.Codigod.HeaderText = "Codigo";
            this.Codigod.Name = "Codigod";
            this.Codigod.ReadOnly = true;
            this.Codigod.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "titulo";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // id_Editorial
            // 
            this.id_Editorial.DataPropertyName = "Editorial";
            this.id_Editorial.HeaderText = "Editorial";
            this.id_Editorial.Name = "id_Editorial";
            this.id_Editorial.ReadOnly = true;
            this.id_Editorial.Visible = false;
            // 
            // Anno
            // 
            this.Anno.DataPropertyName = "anno";
            this.Anno.HeaderText = "Año";
            this.Anno.Name = "Anno";
            this.Anno.ReadOnly = true;
            this.Anno.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgEstudiantes);
            this.tabPage2.Controls.Add(this.btnEliminarEstudiantes);
            this.tabPage2.Controls.Add(this.btnAgregarEstudiantes);
            this.tabPage2.Controls.Add(this.btnReporteEstudiantes);
            this.tabPage2.Controls.Add(this.lstEstudiantes);
            this.tabPage2.Controls.Add(this.btnEliminarEstudiante);
            this.tabPage2.Controls.Add(this.btnAgregarEstudiante);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(688, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reporte de Estudiantes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReporteEstudiantes
            // 
            this.btnReporteEstudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReporteEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteEstudiantes.Location = new System.Drawing.Point(240, 251);
            this.btnReporteEstudiantes.Name = "btnReporteEstudiantes";
            this.btnReporteEstudiantes.Size = new System.Drawing.Size(267, 49);
            this.btnReporteEstudiantes.TabIndex = 26;
            this.btnReporteEstudiantes.Text = "Reporte de Libros";
            this.btnReporteEstudiantes.UseVisualStyleBackColor = true;
            this.btnReporteEstudiantes.Click += new System.EventHandler(this.btnReporteEstudiantes_Click);
            // 
            // lstEstudiantes
            // 
            this.lstEstudiantes.FormattingEnabled = true;
            this.lstEstudiantes.ItemHeight = 16;
            this.lstEstudiantes.Location = new System.Drawing.Point(451, 42);
            this.lstEstudiantes.Name = "lstEstudiantes";
            this.lstEstudiantes.Size = new System.Drawing.Size(209, 180);
            this.lstEstudiantes.TabIndex = 25;
            // 
            // dtgEstudiantes
            // 
            this.dtgEstudiantes.AllowUserToDeleteRows = false;
            this.dtgEstudiantes.AllowUserToResizeColumns = false;
            this.dtgEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QR,
            this.IdCedula,
            this.dataGridViewTextBoxColumn1,
            this.Codigo_QR,
            this.seccion,
            this.Email,
            this.Genero,
            this.Teléfono,
            this.Roll,
            this.F_Nacimiento,
            this.Activo,
            this.Column1});
            this.dtgEstudiantes.Location = new System.Drawing.Point(8, 42);
            this.dtgEstudiantes.MultiSelect = false;
            this.dtgEstudiantes.Name = "dtgEstudiantes";
            this.dtgEstudiantes.ReadOnly = true;
            this.dtgEstudiantes.RowTemplate.Height = 24;
            this.dtgEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEstudiantes.Size = new System.Drawing.Size(363, 175);
            this.dtgEstudiantes.TabIndex = 29;
            // 
            // btnTodosIzquierda
            // 
            this.btnTodosIzquierda.BackgroundImage = global::Capa.UI.Properties.Resources.arrow_left1;
            this.btnTodosIzquierda.Location = new System.Drawing.Point(332, 164);
            this.btnTodosIzquierda.Name = "btnTodosIzquierda";
            this.btnTodosIzquierda.Size = new System.Drawing.Size(68, 35);
            this.btnTodosIzquierda.TabIndex = 21;
            this.btnTodosIzquierda.UseVisualStyleBackColor = true;
            this.btnTodosIzquierda.Click += new System.EventHandler(this.btnTodosIzquierda_Click);
            // 
            // btnTodosDerecha
            // 
            this.btnTodosDerecha.BackgroundImage = global::Capa.UI.Properties.Resources.arrow_right1;
            this.btnTodosDerecha.Location = new System.Drawing.Point(332, 70);
            this.btnTodosDerecha.Name = "btnTodosDerecha";
            this.btnTodosDerecha.Size = new System.Drawing.Size(68, 31);
            this.btnTodosDerecha.TabIndex = 20;
            this.btnTodosDerecha.UseVisualStyleBackColor = true;
            this.btnTodosDerecha.Click += new System.EventHandler(this.btnTodosDerecha_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::Capa.UI.Properties.Resources.arrow_left1;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Location = new System.Drawing.Point(342, 117);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(47, 41);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Capa.UI.Properties.Resources.arrow_right1;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Location = new System.Drawing.Point(342, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(47, 41);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarEstudiantes
            // 
            this.btnEliminarEstudiantes.BackgroundImage = global::Capa.UI.Properties.Resources.arrow_left1;
            this.btnEliminarEstudiantes.Location = new System.Drawing.Point(367, 183);
            this.btnEliminarEstudiantes.Name = "btnEliminarEstudiantes";
            this.btnEliminarEstudiantes.Size = new System.Drawing.Size(68, 35);
            this.btnEliminarEstudiantes.TabIndex = 28;
            this.btnEliminarEstudiantes.UseVisualStyleBackColor = true;
            this.btnEliminarEstudiantes.Click += new System.EventHandler(this.btnEliminarEstudiantes_Click);
            // 
            // btnAgregarEstudiantes
            // 
            this.btnAgregarEstudiantes.BackgroundImage = global::Capa.UI.Properties.Resources.arrow_right1;
            this.btnAgregarEstudiantes.Location = new System.Drawing.Point(367, 89);
            this.btnAgregarEstudiantes.Name = "btnAgregarEstudiantes";
            this.btnAgregarEstudiantes.Size = new System.Drawing.Size(68, 31);
            this.btnAgregarEstudiantes.TabIndex = 27;
            this.btnAgregarEstudiantes.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiantes.Click += new System.EventHandler(this.btnAgregarEstudiantes_Click);
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.BackgroundImage = global::Capa.UI.Properties.Resources.arrow_left1;
            this.btnEliminarEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(377, 136);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(47, 41);
            this.btnEliminarEstudiante.TabIndex = 24;
            this.btnEliminarEstudiante.UseVisualStyleBackColor = true;
            this.btnEliminarEstudiante.Click += new System.EventHandler(this.btnEliminarEstudiante_Click);
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.BackgroundImage = global::Capa.UI.Properties.Resources.arrow_right1;
            this.btnAgregarEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(377, 42);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(47, 41);
            this.btnAgregarEstudiante.TabIndex = 23;
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // QR
            // 
            this.QR.DataPropertyName = "QR";
            this.QR.HeaderText = "Codigo";
            this.QR.Name = "QR";
            this.QR.ReadOnly = true;
            this.QR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.QR.Visible = false;
            // 
            // IdCedula
            // 
            this.IdCedula.DataPropertyName = "IdCedula";
            this.IdCedula.HeaderText = "Cédula";
            this.IdCedula.Name = "IdCedula";
            this.IdCedula.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Codigo_QR
            // 
            this.Codigo_QR.DataPropertyName = "Codigo QR";
            this.Codigo_QR.HeaderText = "Codigo QR";
            this.Codigo_QR.Name = "Codigo_QR";
            this.Codigo_QR.ReadOnly = true;
            this.Codigo_QR.Visible = false;
            // 
            // seccion
            // 
            this.seccion.DataPropertyName = "Seccion";
            this.seccion.HeaderText = "Seccion";
            this.seccion.Name = "seccion";
            this.seccion.ReadOnly = true;
            this.seccion.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "genero";
            this.Genero.HeaderText = "Género";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Visible = false;
            // 
            // Teléfono
            // 
            this.Teléfono.DataPropertyName = "Telefono";
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.Name = "Teléfono";
            this.Teléfono.ReadOnly = true;
            this.Teléfono.Visible = false;
            // 
            // Roll
            // 
            this.Roll.DataPropertyName = "Roll";
            this.Roll.HeaderText = "Tipo";
            this.Roll.Name = "Roll";
            this.Roll.ReadOnly = true;
            this.Roll.Visible = false;
            // 
            // F_Nacimiento
            // 
            this.F_Nacimiento.DataPropertyName = "f_Nacimiento";
            this.F_Nacimiento.HeaderText = "Fecha de Nacimiento";
            this.F_Nacimiento.Name = "F_Nacimiento";
            this.F_Nacimiento.ReadOnly = true;
            this.F_Nacimiento.Visible = false;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Activo.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "contrasenna";
            this.Column1.HeaderText = "Contraseña";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // frmRep_Libros_Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 372);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRep_Libros_Estudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repordete de Libros y Estudiantes";
            this.Load += new System.EventHandler(this.frmRep_Libros_Estudiantes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgLibros;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstLibrosPrestamo;
        private System.Windows.Forms.Button btnRalizarReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anno;
        private System.Windows.Forms.Button btnTodosIzquierda;
        private System.Windows.Forms.Button btnTodosDerecha;
        private System.Windows.Forms.Button btnEliminarEstudiantes;
        private System.Windows.Forms.Button btnAgregarEstudiantes;
        private System.Windows.Forms.Button btnReporteEstudiantes;
        private System.Windows.Forms.ListBox lstEstudiantes;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.DataGridView dtgEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn QR;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_QR;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Nacimiento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}