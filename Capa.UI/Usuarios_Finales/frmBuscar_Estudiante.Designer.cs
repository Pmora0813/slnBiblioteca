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
            this.mskedad = new System.Windows.Forms.MaskedTextBox();
            this.mskNombre = new System.Windows.Forms.MaskedTextBox();
            this.mskCedula = new System.Windows.Forms.MaskedTextBox();
            this.chkSeccion = new System.Windows.Forms.CheckBox();
            this.chkedad = new System.Windows.Forms.CheckBox();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.chkCedula = new System.Windows.Forms.CheckBox();
            this.dtgEstudiantes = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.Controls.Add(this.mskedad);
            this.groupBox1.Controls.Add(this.mskNombre);
            this.groupBox1.Controls.Add(this.mskCedula);
            this.groupBox1.Controls.Add(this.chkSeccion);
            this.groupBox1.Controls.Add(this.chkedad);
            this.groupBox1.Controls.Add(this.chkNombre);
            this.groupBox1.Controls.Add(this.chkCedula);
            this.groupBox1.Location = new System.Drawing.Point(24, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(343, 70);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(118, 31);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(343, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 31);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtSeccion
            // 
            this.txtSeccion.Location = new System.Drawing.Point(168, 107);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(67, 22);
            this.txtSeccion.TabIndex = 7;
            this.txtSeccion.Visible = false;
            // 
            // mskedad
            // 
            this.mskedad.Location = new System.Drawing.Point(36, 107);
            this.mskedad.Mask = "99";
            this.mskedad.Name = "mskedad";
            this.mskedad.Size = new System.Drawing.Size(41, 22);
            this.mskedad.TabIndex = 6;
            this.mskedad.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskedad.Visible = false;
            // 
            // mskNombre
            // 
            this.mskNombre.Location = new System.Drawing.Point(168, 50);
            this.mskNombre.Mask = "LLLLLLLLLLLLL";
            this.mskNombre.Name = "mskNombre";
            this.mskNombre.Size = new System.Drawing.Size(119, 22);
            this.mskNombre.TabIndex = 5;
            this.mskNombre.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskNombre.Visible = false;
            // 
            // mskCedula
            // 
            this.mskCedula.Location = new System.Drawing.Point(38, 50);
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
            this.chkSeccion.Location = new System.Drawing.Point(168, 78);
            this.chkSeccion.Name = "chkSeccion";
            this.chkSeccion.Size = new System.Drawing.Size(76, 20);
            this.chkSeccion.TabIndex = 3;
            this.chkSeccion.Text = "Sección";
            this.chkSeccion.UseVisualStyleBackColor = true;
            this.chkSeccion.CheckedChanged += new System.EventHandler(this.chkSeccion_CheckedChanged);
            // 
            // chkedad
            // 
            this.chkedad.AutoSize = true;
            this.chkedad.Location = new System.Drawing.Point(36, 78);
            this.chkedad.Name = "chkedad";
            this.chkedad.Size = new System.Drawing.Size(60, 20);
            this.chkedad.TabIndex = 2;
            this.chkedad.Text = "Edad";
            this.chkedad.UseVisualStyleBackColor = true;
            this.chkedad.CheckedChanged += new System.EventHandler(this.chkedad_CheckedChanged);
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Location = new System.Drawing.Point(168, 21);
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
            this.chkCedula.Location = new System.Drawing.Point(36, 21);
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
            this.dtgEstudiantes.Location = new System.Drawing.Point(24, 176);
            this.dtgEstudiantes.MultiSelect = false;
            this.dtgEstudiantes.Name = "dtgEstudiantes";
            this.dtgEstudiantes.ReadOnly = true;
            this.dtgEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEstudiantes.Size = new System.Drawing.Size(475, 175);
            this.dtgEstudiantes.TabIndex = 1;
            this.dtgEstudiantes.SelectionChanged += new System.EventHandler(this.dtgEstudiantes_SelectionChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(381, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 31);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmBusquedaAvanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 413);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtgEstudiantes);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusquedaAvanzada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Avanzada";
            this.Load += new System.EventHandler(this.frmBusquedaAvanzada_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSeccion;
        private System.Windows.Forms.CheckBox chkedad;
        private System.Windows.Forms.CheckBox chkNombre;
        private System.Windows.Forms.CheckBox chkCedula;
        private System.Windows.Forms.DataGridView dtgEstudiantes;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.MaskedTextBox mskedad;
        private System.Windows.Forms.MaskedTextBox mskNombre;
        private System.Windows.Forms.MaskedTextBox mskCedula;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
    }
}