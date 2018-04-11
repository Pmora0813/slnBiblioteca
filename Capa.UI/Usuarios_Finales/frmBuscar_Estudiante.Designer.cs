namespace Capa.UI.Usuarios_Finales
{
    partial class frmBuscar_Estudiante
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.mskNombre = new System.Windows.Forms.MaskedTextBox();
            this.mskCedula = new System.Windows.Forms.MaskedTextBox();
            this.chkSeccion = new System.Windows.Forms.CheckBox();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.chkCedula = new System.Windows.Forms.CheckBox();
            this.dtgEstudiantes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasenna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtSeccion);
            this.groupBox1.Controls.Add(this.mskNombre);
            this.groupBox1.Controls.Add(this.mskCedula);
            this.groupBox1.Controls.Add(this.chkSeccion);
            this.groupBox1.Controls.Add(this.chkNombre);
            this.groupBox1.Controls.Add(this.chkCedula);
            this.groupBox1.Location = new System.Drawing.Point(24, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Capa.UI.Properties.Resources.sign_up;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(352, 73);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(118, 44);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Seleccionar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Capa.UI.Properties.Resources.publish;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Location = new System.Drawing.Point(352, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 42);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar Estudiante";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtSeccion
            // 
            this.txtSeccion.Location = new System.Drawing.Point(250, 50);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(67, 22);
            this.txtSeccion.TabIndex = 7;
            this.txtSeccion.Visible = false;
            // 
            // mskNombre
            // 
            this.mskNombre.Location = new System.Drawing.Point(116, 50);
            this.mskNombre.Mask = "LLLLLLLLLLLLL";
            this.mskNombre.Name = "mskNombre";
            this.mskNombre.Size = new System.Drawing.Size(119, 22);
            this.mskNombre.TabIndex = 5;
            this.mskNombre.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskNombre.Visible = false;
            // 
            // mskCedula
            // 
            this.mskCedula.Location = new System.Drawing.Point(8, 50);
            this.mskCedula.Mask = "9-9999-9999";
            this.mskCedula.Name = "mskCedula";
            this.mskCedula.Size = new System.Drawing.Size(97, 22);
            this.mskCedula.TabIndex = 4;
            this.mskCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCedula.Visible = false;
            // 
            // chkSeccion
            // 
            this.chkSeccion.AutoSize = true;
            this.chkSeccion.Location = new System.Drawing.Point(250, 21);
            this.chkSeccion.Name = "chkSeccion";
            this.chkSeccion.Size = new System.Drawing.Size(76, 20);
            this.chkSeccion.TabIndex = 3;
            this.chkSeccion.Text = "Sección";
            this.chkSeccion.UseVisualStyleBackColor = true;
            this.chkSeccion.CheckedChanged += new System.EventHandler(this.chkSeccion_CheckedChanged);
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Location = new System.Drawing.Point(116, 21);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(76, 20);
            this.chkNombre.TabIndex = 1;
            this.chkNombre.Text = "Nombre";
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // chkCedula
            // 
            this.chkCedula.AutoSize = true;
            this.chkCedula.Location = new System.Drawing.Point(6, 21);
            this.chkCedula.Name = "chkCedula";
            this.chkCedula.Size = new System.Drawing.Size(70, 20);
            this.chkCedula.TabIndex = 0;
            this.chkCedula.Text = "Cédula";
            this.chkCedula.UseVisualStyleBackColor = true;
            this.chkCedula.CheckedChanged += new System.EventHandler(this.chkCedula_CheckedChanged);
            // 
            // dtgEstudiantes
            // 
            this.dtgEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cedula,
            this.Seccion,
            this.Contrasenna,
            this.Genero,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgEstudiantes.Location = new System.Drawing.Point(19, 145);
            this.dtgEstudiantes.MultiSelect = false;
            this.dtgEstudiantes.Name = "dtgEstudiantes";
            this.dtgEstudiantes.ReadOnly = true;
            this.dtgEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEstudiantes.Size = new System.Drawing.Size(475, 175);
            this.dtgEstudiantes.TabIndex = 1;
            this.dtgEstudiantes.SelectionChanged += new System.EventHandler(this.dtgEstudiantes_SelectionChanged);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "idCedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Seccion
            // 
            this.Seccion.DataPropertyName = "seccion";
            this.Seccion.HeaderText = "Sección";
            this.Seccion.Name = "Seccion";
            this.Seccion.ReadOnly = true;
            // 
            // Contrasenna
            // 
            this.Contrasenna.DataPropertyName = "Contrasenna";
            this.Contrasenna.HeaderText = "Contrasenna";
            this.Contrasenna.Name = "Contrasenna";
            this.Contrasenna.ReadOnly = true;
            this.Contrasenna.Visible = false;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "f_Nacimiento";
            this.Column1.HeaderText = "Fna";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "email";
            this.Column2.HeaderText = "email";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "telefono";
            this.Column3.HeaderText = "telefono";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "activo";
            this.Column4.HeaderText = "activo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "QR";
            this.Column5.HeaderText = "QR";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ROLL";
            this.Column6.HeaderText = "ROll";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Capa.UI.Properties.Resources.sign_out;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Location = new System.Drawing.Point(407, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 44);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBuscar_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 394);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtgEstudiantes);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscar_Estudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Avanzada";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSeccion;
        private System.Windows.Forms.CheckBox chkNombre;
        private System.Windows.Forms.CheckBox chkCedula;
        private System.Windows.Forms.DataGridView dtgEstudiantes;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.MaskedTextBox mskNombre;
        private System.Windows.Forms.MaskedTextBox mskCedula;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasenna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}