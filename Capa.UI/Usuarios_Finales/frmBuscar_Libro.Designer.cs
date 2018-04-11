namespace Capa.UI.Usuarios_Finales
{
    partial class frmBuscar_Libro
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
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.txtTiluto = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mskAnno = new System.Windows.Forms.MaskedTextBox();
            this.chkAnno = new System.Windows.Forms.CheckBox();
            this.chkEditorial = new System.Windows.Forms.CheckBox();
            this.chkAutor = new System.Windows.Forms.CheckBox();
            this.chkTitulo = new System.Windows.Forms.CheckBox();
            this.dtgLibros = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAutor);
            this.groupBox1.Controls.Add(this.cmbEditorial);
            this.groupBox1.Controls.Add(this.txtTiluto);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.mskAnno);
            this.groupBox1.Controls.Add(this.chkAnno);
            this.groupBox1.Controls.Add(this.chkEditorial);
            this.groupBox1.Controls.Add(this.chkAutor);
            this.groupBox1.Controls.Add(this.chkTitulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cmbAutor
            // 
            this.cmbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(179, 104);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(121, 24);
            this.cmbAutor.TabIndex = 13;
            this.cmbAutor.Visible = false;
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(36, 102);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(121, 24);
            this.cmbEditorial.TabIndex = 12;
            this.cmbEditorial.Visible = false;
            // 
            // txtTiluto
            // 
            this.txtTiluto.Location = new System.Drawing.Point(36, 45);
            this.txtTiluto.Name = "txtTiluto";
            this.txtTiluto.Size = new System.Drawing.Size(121, 22);
            this.txtTiluto.TabIndex = 10;
            this.txtTiluto.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Capa.UI.Properties.Resources.sign_up;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(328, 85);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(127, 41);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Seleccionar ";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Capa.UI.Properties.Resources.publish;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Location = new System.Drawing.Point(328, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 43);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar Libro";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mskAnno
            // 
            this.mskAnno.Location = new System.Drawing.Point(179, 41);
            this.mskAnno.Mask = "9999";
            this.mskAnno.Name = "mskAnno";
            this.mskAnno.Size = new System.Drawing.Size(65, 22);
            this.mskAnno.TabIndex = 6;
            this.mskAnno.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskAnno.Visible = false;
            // 
            // chkAnno
            // 
            this.chkAnno.AutoSize = true;
            this.chkAnno.Location = new System.Drawing.Point(179, 21);
            this.chkAnno.Name = "chkAnno";
            this.chkAnno.Size = new System.Drawing.Size(51, 20);
            this.chkAnno.TabIndex = 3;
            this.chkAnno.Text = "Año";
            this.chkAnno.UseVisualStyleBackColor = true;
            this.chkAnno.CheckedChanged += new System.EventHandler(this.chkAnno_CheckedChanged);
            // 
            // chkEditorial
            // 
            this.chkEditorial.AutoSize = true;
            this.chkEditorial.Location = new System.Drawing.Point(36, 78);
            this.chkEditorial.Name = "chkEditorial";
            this.chkEditorial.Size = new System.Drawing.Size(76, 20);
            this.chkEditorial.TabIndex = 2;
            this.chkEditorial.Text = "Editorial";
            this.chkEditorial.UseVisualStyleBackColor = true;
            this.chkEditorial.CheckedChanged += new System.EventHandler(this.chkEditorial_CheckedChanged);
            // 
            // chkAutor
            // 
            this.chkAutor.AutoSize = true;
            this.chkAutor.Location = new System.Drawing.Point(179, 75);
            this.chkAutor.Name = "chkAutor";
            this.chkAutor.Size = new System.Drawing.Size(58, 20);
            this.chkAutor.TabIndex = 1;
            this.chkAutor.Text = "Autor";
            this.chkAutor.UseVisualStyleBackColor = true;
            this.chkAutor.CheckedChanged += new System.EventHandler(this.chkAutor_CheckedChanged);
            // 
            // chkTitulo
            // 
            this.chkTitulo.AutoSize = true;
            this.chkTitulo.Location = new System.Drawing.Point(36, 21);
            this.chkTitulo.Name = "chkTitulo";
            this.chkTitulo.Size = new System.Drawing.Size(60, 20);
            this.chkTitulo.TabIndex = 0;
            this.chkTitulo.Text = "Titulo";
            this.chkTitulo.UseVisualStyleBackColor = true;
            this.chkTitulo.CheckedChanged += new System.EventHandler(this.chkTitulo_CheckedChanged);
            // 
            // dtgLibros
            // 
            this.dtgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Qr,
            this.titulo,
            this.Anno,
            this.Editorial});
            this.dtgLibros.Location = new System.Drawing.Point(13, 172);
            this.dtgLibros.MultiSelect = false;
            this.dtgLibros.Name = "dtgLibros";
            this.dtgLibros.ReadOnly = true;
            this.dtgLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLibros.Size = new System.Drawing.Size(460, 175);
            this.dtgLibros.TabIndex = 2;
            this.dtgLibros.SelectionChanged += new System.EventHandler(this.dtgLibros_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Qr
            // 
            this.Qr.DataPropertyName = "Qr";
            this.Qr.HeaderText = "QR";
            this.Qr.Name = "Qr";
            this.Qr.ReadOnly = true;
            this.Qr.Visible = false;
            // 
            // titulo
            // 
            this.titulo.DataPropertyName = "titulo";
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // Anno
            // 
            this.Anno.DataPropertyName = "anno";
            this.Anno.HeaderText = "Año";
            this.Anno.Name = "Anno";
            this.Anno.ReadOnly = true;
            // 
            // Editorial
            // 
            this.Editorial.DataPropertyName = "Editorial";
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.Name = "Editorial";
            this.Editorial.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Capa.UI.Properties.Resources.sign_out;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Location = new System.Drawing.Point(389, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBuscar_Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 398);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtgLibros);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscar_Libro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Avazada";
            this.Load += new System.EventHandler(this.frmBuscar_Libro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.TextBox txtTiluto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mskAnno;
        private System.Windows.Forms.CheckBox chkAnno;
        private System.Windows.Forms.CheckBox chkEditorial;
        private System.Windows.Forms.CheckBox chkAutor;
        private System.Windows.Forms.CheckBox chkTitulo;
        private System.Windows.Forms.DataGridView dtgLibros;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qr;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
    }
}