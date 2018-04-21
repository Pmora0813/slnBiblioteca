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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mskCodigoprestamo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLibrosPrestamo = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpRealizarDevolucion = new System.Windows.Forms.TabPage();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.mskCodigoLibro = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlFaltaLibro = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpRealizarDevolucion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(573, 384);
            this.tabControl1.TabIndex = 6;
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
            this.tbpRealizarDevolucion.Text = "Realizar Devolució";
            this.tbpRealizarDevolucion.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(705, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpRealizarDevolucion.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mskCodigoprestamo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLibrosPrestamo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpRealizarDevolucion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.MaskedTextBox mskCodigoLibro;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlFaltaLibro;
        private System.Windows.Forms.Button btnAceptar;
    }
}