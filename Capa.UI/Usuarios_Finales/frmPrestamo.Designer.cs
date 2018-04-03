namespace Capa.UI.Usuarios_Finales
{
    partial class frmPrestamo
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
            this.C = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo_Prestamo = new System.Windows.Forms.TextBox();
            this.dtpFecha_Dev = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBuscar_Estudiantes = new System.Windows.Forms.Label();
            this.btnBuscar_est = new System.Windows.Forms.Button();
            this.txtSeccion_est = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskCedula_estudiant = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre_est = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaAct = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBuscar_Libros = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskCodigo_Libro = new System.Windows.Forms.MaskedTextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoSolicitud = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.wbbMostrar = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(24, 14);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(52, 16);
            this.C.TabIndex = 0;
            this.C.Text = "&Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Devulución";
            // 
            // txtCodigo_Prestamo
            // 
            this.txtCodigo_Prestamo.Enabled = false;
            this.txtCodigo_Prestamo.Location = new System.Drawing.Point(91, 13);
            this.txtCodigo_Prestamo.Name = "txtCodigo_Prestamo";
            this.txtCodigo_Prestamo.Size = new System.Drawing.Size(81, 22);
            this.txtCodigo_Prestamo.TabIndex = 10;
            // 
            // dtpFecha_Dev
            // 
            this.dtpFecha_Dev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Dev.Location = new System.Drawing.Point(106, 400);
            this.dtpFecha_Dev.Name = "dtpFecha_Dev";
            this.dtpFecha_Dev.Size = new System.Drawing.Size(111, 22);
            this.dtpFecha_Dev.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBuscar_Estudiantes);
            this.groupBox1.Controls.Add(this.btnBuscar_est);
            this.groupBox1.Controls.Add(this.txtSeccion_est);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mskCedula_estudiant);
            this.groupBox1.Controls.Add(this.txtNombre_est);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(29, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 149);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Estudiante";
            // 
            // lblBuscar_Estudiantes
            // 
            this.lblBuscar_Estudiantes.AutoSize = true;
            this.lblBuscar_Estudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBuscar_Estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBuscar_Estudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar_Estudiantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBuscar_Estudiantes.Location = new System.Drawing.Point(213, 74);
            this.lblBuscar_Estudiantes.Name = "lblBuscar_Estudiantes";
            this.lblBuscar_Estudiantes.Size = new System.Drawing.Size(151, 16);
            this.lblBuscar_Estudiantes.TabIndex = 8;
            this.lblBuscar_Estudiantes.Text = "Busqueda Avanzada";
            this.lblBuscar_Estudiantes.Click += new System.EventHandler(this.lblBus_Avanzada_Click);
            // 
            // btnBuscar_est
            // 
            this.btnBuscar_est.Location = new System.Drawing.Point(216, 31);
            this.btnBuscar_est.Name = "btnBuscar_est";
            this.btnBuscar_est.Size = new System.Drawing.Size(85, 36);
            this.btnBuscar_est.TabIndex = 7;
            this.btnBuscar_est.Text = "Buscar";
            this.btnBuscar_est.UseVisualStyleBackColor = true;
            this.btnBuscar_est.Click += new System.EventHandler(this.btnBuscar_est_Click);
            // 
            // txtSeccion_est
            // 
            this.txtSeccion_est.Enabled = false;
            this.txtSeccion_est.Location = new System.Drawing.Point(79, 107);
            this.txtSeccion_est.Name = "txtSeccion_est";
            this.txtSeccion_est.Size = new System.Drawing.Size(61, 22);
            this.txtSeccion_est.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sección";
            // 
            // mskCedula_estudiant
            // 
            this.mskCedula_estudiant.Location = new System.Drawing.Point(79, 31);
            this.mskCedula_estudiant.Mask = "9-9999-9999";
            this.mskCedula_estudiant.Name = "mskCedula_estudiant";
            this.mskCedula_estudiant.Size = new System.Drawing.Size(117, 22);
            this.mskCedula_estudiant.TabIndex = 4;
            this.mskCedula_estudiant.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNombre_est
            // 
            this.txtNombre_est.Enabled = false;
            this.txtNombre_est.Location = new System.Drawing.Point(79, 68);
            this.txtNombre_est.Name = "txtNombre_est";
            this.txtNombre_est.Size = new System.Drawing.Size(119, 22);
            this.txtNombre_est.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cedula";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(530, 13);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(126, 22);
            this.txtUsuario.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario";
            // 
            // dtpFechaAct
            // 
            this.dtpFechaAct.Enabled = false;
            this.dtpFechaAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAct.Location = new System.Drawing.Point(739, 12);
            this.dtpFechaAct.Name = "dtpFechaAct";
            this.dtpFechaAct.Size = new System.Drawing.Size(126, 22);
            this.dtpFechaAct.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBuscar_Libros);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtAnno);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mskCodigo_Libro);
            this.groupBox2.Controls.Add(this.txtTitulo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(27, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 149);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Libro";
            // 
            // lblBuscar_Libros
            // 
            this.lblBuscar_Libros.AutoSize = true;
            this.lblBuscar_Libros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBuscar_Libros.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBuscar_Libros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar_Libros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBuscar_Libros.Location = new System.Drawing.Point(213, 74);
            this.lblBuscar_Libros.Name = "lblBuscar_Libros";
            this.lblBuscar_Libros.Size = new System.Drawing.Size(151, 16);
            this.lblBuscar_Libros.TabIndex = 8;
            this.lblBuscar_Libros.Text = "Busqueda Avanzada";
            this.lblBuscar_Libros.Click += new System.EventHandler(this.lblBuscar_Libros_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(216, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 36);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtAnno
            // 
            this.txtAnno.Enabled = false;
            this.txtAnno.Location = new System.Drawing.Point(79, 107);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(61, 22);
            this.txtAnno.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Año";
            // 
            // mskCodigo_Libro
            // 
            this.mskCodigo_Libro.Location = new System.Drawing.Point(79, 31);
            this.mskCodigo_Libro.Mask = "99999999999999";
            this.mskCodigo_Libro.Name = "mskCodigo_Libro";
            this.mskCodigo_Libro.Size = new System.Drawing.Size(117, 22);
            this.mskCodigo_Libro.TabIndex = 4;
            this.mskCodigo_Libro.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(79, 68);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(119, 22);
            this.txtTitulo.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Titulo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Código";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo de Solicitud";
            // 
            // cmbTipoSolicitud
            // 
            this.cmbTipoSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSolicitud.FormattingEnabled = true;
            this.cmbTipoSolicitud.Location = new System.Drawing.Point(245, 400);
            this.cmbTipoSolicitud.Name = "cmbTipoSolicitud";
            this.cmbTipoSolicitud.Size = new System.Drawing.Size(169, 24);
            this.cmbTipoSolicitud.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(67, 459);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 46);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(245, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 46);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // wbbMostrar
            // 
            this.wbbMostrar.Location = new System.Drawing.Point(515, 53);
            this.wbbMostrar.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbbMostrar.Name = "wbbMostrar";
            this.wbbMostrar.Size = new System.Drawing.Size(350, 452);
            this.wbbMostrar.TabIndex = 21;
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 528);
            this.Controls.Add(this.wbbMostrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbTipoSolicitud);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpFechaAct);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFecha_Dev);
            this.Controls.Add(this.txtCodigo_Prestamo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.C);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamo de Libros";
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo_Prestamo;
        private System.Windows.Forms.DateTimePicker dtpFecha_Dev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar_est;
        private System.Windows.Forms.TextBox txtSeccion_est;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskCedula_estudiant;
        private System.Windows.Forms.TextBox txtNombre_est;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBuscar_Estudiantes;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaAct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBuscar_Libros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskCodigo_Libro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoSolicitud;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.WebBrowser wbbMostrar;
    }
}