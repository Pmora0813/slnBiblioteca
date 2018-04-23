namespace Capa.UI.Menu_Estudiante
{
    partial class frmPrestamo_Estudiente
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.C = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaAct = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.mskCodigo_Libro = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnBusquedaAvanzadaLibro = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFecha_Dev = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoSolicitud = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre_est = new System.Windows.Forms.TextBox();
            this.mskCedula_estudiant = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeccion_est = new System.Windows.Forms.TextBox();
            this.btnBuscar_est = new System.Windows.Forms.Button();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.txtCodigo_Prestamo = new System.Windows.Forms.TextBox();
            this.wbbMostrar = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnNuevoPresta = new System.Windows.Forms.Button();
            this.dtgSolicitudes_Solicitud = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mskCodigoprestamo = new System.Windows.Forms.MaskedTextBox();
            this.btnRealizarDevolucion = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaEs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autoriazado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolicitudes_Solicitud)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRealizarDevolucion);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.dtgSolicitudes_Solicitud);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Realizar Solicidud de Devolucion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNuevoPresta);
            this.tabPage1.Controls.Add(this.wbbMostrar);
            this.tabPage1.Controls.Add(this.txtCodigo_Prestamo);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btnEnviarCorreo);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dtpFechaAct);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.C);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Realizar Solicitud de Prestamo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(20, 12);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(52, 16);
            this.C.TabIndex = 36;
            this.C.Text = "&Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "&Fecha";
            // 
            // dtpFechaAct
            // 
            this.dtpFechaAct.Enabled = false;
            this.dtpFechaAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAct.Location = new System.Drawing.Point(256, 12);
            this.dtpFechaAct.Name = "dtpFechaAct";
            this.dtpFechaAct.Size = new System.Drawing.Size(126, 22);
            this.dtpFechaAct.TabIndex = 42;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAceptar);
            this.groupBox2.Controls.Add(this.btnBusquedaAvanzadaLibro);
            this.groupBox2.Controls.Add(this.btnBuscarLibro);
            this.groupBox2.Controls.Add(this.txtAnno);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mskCodigo_Libro);
            this.groupBox2.Controls.Add(this.txtTitulo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(25, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 173);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Libros";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(79, 68);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(119, 22);
            this.txtTitulo.TabIndex = 3;
            // 
            // mskCodigo_Libro
            // 
            this.mskCodigo_Libro.Location = new System.Drawing.Point(79, 31);
            this.mskCodigo_Libro.Mask = "99999999999999";
            this.mskCodigo_Libro.Name = "mskCodigo_Libro";
            this.mskCodigo_Libro.Size = new System.Drawing.Size(117, 22);
            this.mskCodigo_Libro.TabIndex = 4;
            this.mskCodigo_Libro.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCodigo_Libro.TextChanged += new System.EventHandler(this.mskCodigo_Libro_TextChanged);
            this.mskCodigo_Libro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskCodigo_Libro_KeyDown);
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
            // txtAnno
            // 
            this.txtAnno.Enabled = false;
            this.txtAnno.Location = new System.Drawing.Point(79, 107);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(61, 22);
            this.txtAnno.TabIndex = 6;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.BackgroundImage = global::Capa.UI.Properties.Resources.search1;
            this.btnBuscarLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarLibro.Location = new System.Drawing.Point(216, 22);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(93, 40);
            this.btnBuscarLibro.TabIndex = 7;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // btnBusquedaAvanzadaLibro
            // 
            this.btnBusquedaAvanzadaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBusquedaAvanzadaLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnBusquedaAvanzadaLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnBusquedaAvanzadaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaAvanzadaLibro.Location = new System.Drawing.Point(216, 121);
            this.btnBusquedaAvanzadaLibro.Name = "btnBusquedaAvanzadaLibro";
            this.btnBusquedaAvanzadaLibro.Size = new System.Drawing.Size(152, 28);
            this.btnBusquedaAvanzadaLibro.TabIndex = 10;
            this.btnBusquedaAvanzadaLibro.Text = "Busqueda Avanzada";
            this.btnBusquedaAvanzadaLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusquedaAvanzadaLibro.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzadaLibro.Click += new System.EventHandler(this.btnBusquedaAvanzadaLibro_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Capa.UI.Properties.Resources.sign_up;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Location = new System.Drawing.Point(216, 68);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 37);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Capa.UI.Properties.Resources.refresh;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(750, 545);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 46);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.BackgroundImage = global::Capa.UI.Properties.Resources.contact;
            this.btnEnviarCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(571, 545);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(173, 46);
            this.btnEnviarCorreo.TabIndex = 44;
            this.btnEnviarCorreo.Text = "Enviar Comprobante";
            this.btnEnviarCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviarCorreo.UseVisualStyleBackColor = true;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbTipoSolicitud);
            this.groupBox3.Controls.Add(this.dtpFecha_Dev);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(25, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 313);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion del Prestamo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo de Solicitud";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Capa.UI.Properties.Resources.disk;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Location = new System.Drawing.Point(12, 261);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 46);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFecha_Dev
            // 
            this.dtpFecha_Dev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Dev.Location = new System.Drawing.Point(14, 215);
            this.dtpFecha_Dev.Name = "dtpFecha_Dev";
            this.dtpFecha_Dev.Size = new System.Drawing.Size(111, 22);
            this.dtpFecha_Dev.TabIndex = 12;
            // 
            // cmbTipoSolicitud
            // 
            this.cmbTipoSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSolicitud.FormattingEnabled = true;
            this.cmbTipoSolicitud.Location = new System.Drawing.Point(153, 215);
            this.cmbTipoSolicitud.Name = "cmbTipoSolicitud";
            this.cmbTipoSolicitud.Size = new System.Drawing.Size(169, 24);
            this.cmbTipoSolicitud.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Devulución";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBusquedaAvanzada);
            this.groupBox1.Controls.Add(this.btnBuscar_est);
            this.groupBox1.Controls.Add(this.txtSeccion_est);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mskCedula_estudiant);
            this.groupBox1.Controls.Add(this.txtNombre_est);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 149);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estudiante";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // txtNombre_est
            // 
            this.txtNombre_est.Enabled = false;
            this.txtNombre_est.Location = new System.Drawing.Point(79, 68);
            this.txtNombre_est.Name = "txtNombre_est";
            this.txtNombre_est.Size = new System.Drawing.Size(119, 22);
            this.txtNombre_est.TabIndex = 3;
            // 
            // mskCedula_estudiant
            // 
            this.mskCedula_estudiant.Location = new System.Drawing.Point(79, 31);
            this.mskCedula_estudiant.Mask = "9-9999-9999";
            this.mskCedula_estudiant.Name = "mskCedula_estudiant";
            this.mskCedula_estudiant.Size = new System.Drawing.Size(117, 22);
            this.mskCedula_estudiant.TabIndex = 4;
            this.mskCedula_estudiant.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCedula_estudiant.TextChanged += new System.EventHandler(this.mskCedula_estudiant_TextChanged);
            this.mskCedula_estudiant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskCedula_estudiant_KeyDown);
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
            // txtSeccion_est
            // 
            this.txtSeccion_est.Enabled = false;
            this.txtSeccion_est.Location = new System.Drawing.Point(79, 107);
            this.txtSeccion_est.Name = "txtSeccion_est";
            this.txtSeccion_est.Size = new System.Drawing.Size(61, 22);
            this.txtSeccion_est.TabIndex = 6;
            // 
            // btnBuscar_est
            // 
            this.btnBuscar_est.BackgroundImage = global::Capa.UI.Properties.Resources.search1;
            this.btnBuscar_est.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar_est.Location = new System.Drawing.Point(214, 31);
            this.btnBuscar_est.Name = "btnBuscar_est";
            this.btnBuscar_est.Size = new System.Drawing.Size(93, 39);
            this.btnBuscar_est.TabIndex = 7;
            this.btnBuscar_est.Text = "Buscar";
            this.btnBuscar_est.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar_est.UseVisualStyleBackColor = true;
            this.btnBuscar_est.Click += new System.EventHandler(this.btnBuscar_est_Click);
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBusquedaAvanzada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnBusquedaAvanzada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(214, 76);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(152, 28);
            this.btnBusquedaAvanzada.TabIndex = 9;
            this.btnBusquedaAvanzada.Text = "Busqueda Avanzada";
            this.btnBusquedaAvanzada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // txtCodigo_Prestamo
            // 
            this.txtCodigo_Prestamo.Enabled = false;
            this.txtCodigo_Prestamo.Location = new System.Drawing.Point(87, 11);
            this.txtCodigo_Prestamo.Name = "txtCodigo_Prestamo";
            this.txtCodigo_Prestamo.Size = new System.Drawing.Size(76, 22);
            this.txtCodigo_Prestamo.TabIndex = 38;
            // 
            // wbbMostrar
            // 
            this.wbbMostrar.Location = new System.Drawing.Point(456, 58);
            this.wbbMostrar.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbbMostrar.Name = "wbbMostrar";
            this.wbbMostrar.Size = new System.Drawing.Size(340, 446);
            this.wbbMostrar.TabIndex = 46;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 623);
            this.tabControl1.TabIndex = 0;
            // 
            // btnNuevoPresta
            // 
            this.btnNuevoPresta.BackgroundImage = global::Capa.UI.Properties.Resources.sign_up11;
            this.btnNuevoPresta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevoPresta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevoPresta.Location = new System.Drawing.Point(415, 545);
            this.btnNuevoPresta.Name = "btnNuevoPresta";
            this.btnNuevoPresta.Size = new System.Drawing.Size(150, 46);
            this.btnNuevoPresta.TabIndex = 47;
            this.btnNuevoPresta.Text = "Nuevo Prestamo";
            this.btnNuevoPresta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoPresta.UseVisualStyleBackColor = true;
            this.btnNuevoPresta.Click += new System.EventHandler(this.btnNuevoPresta_Click);
            // 
            // dtgSolicitudes_Solicitud
            // 
            this.dtgSolicitudes_Solicitud.AllowUserToAddRows = false;
            this.dtgSolicitudes_Solicitud.AllowUserToDeleteRows = false;
            this.dtgSolicitudes_Solicitud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSolicitudes_Solicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSolicitudes_Solicitud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CedulaEs,
            this.FechaDevo,
            this.Autoriazado,
            this.horas,
            this.dias,
            this.fechaa,
            this.minu,
            this.categoria});
            this.dtgSolicitudes_Solicitud.Location = new System.Drawing.Point(26, 126);
            this.dtgSolicitudes_Solicitud.MultiSelect = false;
            this.dtgSolicitudes_Solicitud.Name = "dtgSolicitudes_Solicitud";
            this.dtgSolicitudes_Solicitud.ReadOnly = true;
            this.dtgSolicitudes_Solicitud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSolicitudes_Solicitud.Size = new System.Drawing.Size(559, 170);
            this.dtgSolicitudes_Solicitud.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.mskCodigoprestamo);
            this.groupBox4.Location = new System.Drawing.Point(26, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 91);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Información del Prestamo";
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
            this.btnBuscar.Location = new System.Drawing.Point(169, 21);
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
            // 
            // btnRealizarDevolucion
            // 
            this.btnRealizarDevolucion.Location = new System.Drawing.Point(458, 34);
            this.btnRealizarDevolucion.Name = "btnRealizarDevolucion";
            this.btnRealizarDevolucion.Size = new System.Drawing.Size(127, 38);
            this.btnRealizarDevolucion.TabIndex = 4;
            this.btnRealizarDevolucion.Text = "Buscar Prestamo";
            this.btnRealizarDevolucion.UseVisualStyleBackColor = true;
            this.btnRealizarDevolucion.Click += new System.EventHandler(this.btnRealizarDevolucion_Click);
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
            this.Autoriazado.Visible = false;
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
            // frmPrestamo_Estudiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 623);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrestamo_Estudiente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamo Estudiente";
            this.Load += new System.EventHandler(this.frmPrestamo_Estudiente_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolicitudes_Solicitud)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNuevoPresta;
        private System.Windows.Forms.WebBrowser wbbMostrar;
        private System.Windows.Forms.TextBox txtCodigo_Prestamo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.Button btnBuscar_est;
        private System.Windows.Forms.TextBox txtSeccion_est;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskCedula_estudiant;
        private System.Windows.Forms.TextBox txtNombre_est;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoSolicitud;
        private System.Windows.Forms.DateTimePicker dtpFecha_Dev;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEnviarCorreo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBusquedaAvanzadaLibro;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskCodigo_Libro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFechaAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dtgSolicitudes_Solicitud;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mskCodigoprestamo;
        private System.Windows.Forms.Button btnRealizarDevolucion;
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