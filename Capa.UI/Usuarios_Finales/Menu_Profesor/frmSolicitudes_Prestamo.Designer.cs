namespace Capa.UI.Usuarios_Finales.Menu_Profesor
{
    partial class frmSolicitudes_Prestamo
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
            this.dtgSolicitudes_Prestamo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgLibros = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarSolicitud = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaEs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autoriazado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolicitudes_Prestamo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSolicitudes_Prestamo
            // 
            this.dtgSolicitudes_Prestamo.AllowUserToAddRows = false;
            this.dtgSolicitudes_Prestamo.AllowUserToDeleteRows = false;
            this.dtgSolicitudes_Prestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSolicitudes_Prestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CedulaEs,
            this.FechaDevo,
            this.Autoriazado,
            this.horas,
            this.fechadev,
            this.dias,
            this.fechaa,
            this.minu,
            this.categoria});
            this.dtgSolicitudes_Prestamo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgSolicitudes_Prestamo.Location = new System.Drawing.Point(0, 148);
            this.dtgSolicitudes_Prestamo.Margin = new System.Windows.Forms.Padding(4);
            this.dtgSolicitudes_Prestamo.MultiSelect = false;
            this.dtgSolicitudes_Prestamo.Name = "dtgSolicitudes_Prestamo";
            this.dtgSolicitudes_Prestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSolicitudes_Prestamo.Size = new System.Drawing.Size(579, 174);
            this.dtgSolicitudes_Prestamo.TabIndex = 1;
            this.dtgSolicitudes_Prestamo.SelectionChanged += new System.EventHandler(this.dtgSolicitudes_Prestamo_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgLibros);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAceptarSolicitud);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aceptar Solicitudes";
            // 
            // dtgLibros
            // 
            this.dtgLibros.AllowUserToAddRows = false;
            this.dtgLibros.AllowUserToDeleteRows = false;
            this.dtgLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Titulo,
            this.anno,
            this.Editorial,
            this.Qr});
            this.dtgLibros.Location = new System.Drawing.Point(152, 55);
            this.dtgLibros.MultiSelect = false;
            this.dtgLibros.Name = "dtgLibros";
            this.dtgLibros.ReadOnly = true;
            this.dtgLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLibros.Size = new System.Drawing.Size(224, 85);
            this.dtgLibros.TabIndex = 5;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Codigo";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // anno
            // 
            this.anno.DataPropertyName = "anno";
            this.anno.HeaderText = "Anno";
            this.anno.Name = "anno";
            this.anno.ReadOnly = true;
            this.anno.Visible = false;
            // 
            // Editorial
            // 
            this.Editorial.DataPropertyName = "editorial";
            this.Editorial.HeaderText = "editorial";
            this.Editorial.Name = "Editorial";
            this.Editorial.ReadOnly = true;
            this.Editorial.Visible = false;
            // 
            // Qr
            // 
            this.Qr.DataPropertyName = "qr";
            this.Qr.HeaderText = "Qr";
            this.Qr.Name = "Qr";
            this.Qr.ReadOnly = true;
            this.Qr.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(443, 81);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 34);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar ";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(17, 56);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(104, 22);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // btnAceptarSolicitud
            // 
            this.btnAceptarSolicitud.Location = new System.Drawing.Point(443, 41);
            this.btnAceptarSolicitud.Name = "btnAceptarSolicitud";
            this.btnAceptarSolicitud.Size = new System.Drawing.Size(124, 34);
            this.btnAceptarSolicitud.TabIndex = 0;
            this.btnAceptarSolicitud.Text = "Aceptar Solicitud";
            this.btnAceptarSolicitud.UseVisualStyleBackColor = true;
            this.btnAceptarSolicitud.Click += new System.EventHandler(this.btnAceptarSolicitud_Click);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "id";
            this.Codigo.FillWeight = 91.42326F;
            this.Codigo.HeaderText = "Prestamo #";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CedulaEs
            // 
            this.CedulaEs.DataPropertyName = "estudiant";
            this.CedulaEs.FillWeight = 102.33F;
            this.CedulaEs.HeaderText = "Estudiante";
            this.CedulaEs.Name = "CedulaEs";
            this.CedulaEs.ReadOnly = true;
            this.CedulaEs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaDevo
            // 
            this.FechaDevo.DataPropertyName = "fecha_Act";
            this.FechaDevo.FillWeight = 114.153F;
            this.FechaDevo.HeaderText = "Fecha Solicitud";
            this.FechaDevo.Name = "FechaDevo";
            this.FechaDevo.ReadOnly = true;
            this.FechaDevo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Autoriazado
            // 
            this.Autoriazado.DataPropertyName = "USUARIO";
            this.Autoriazado.FillWeight = 126.9035F;
            this.Autoriazado.HeaderText = "Prestado por";
            this.Autoriazado.Name = "Autoriazado";
            this.Autoriazado.ReadOnly = true;
            this.Autoriazado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // horas
            // 
            this.horas.DataPropertyName = "horas";
            this.horas.HeaderText = "horas";
            this.horas.Name = "horas";
            this.horas.ReadOnly = true;
            this.horas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.horas.Visible = false;
            // 
            // fechadev
            // 
            this.fechadev.DataPropertyName = "Fecha_Dev";
            this.fechadev.HeaderText = "devo";
            this.fechadev.Name = "fechadev";
            this.fechadev.Visible = false;
            // 
            // dias
            // 
            this.dias.DataPropertyName = "dias";
            this.dias.HeaderText = "Dias";
            this.dias.Name = "dias";
            this.dias.ReadOnly = true;
            this.dias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dias.Visible = false;
            // 
            // fechaa
            // 
            this.fechaa.DataPropertyName = "fecha_act";
            this.fechaa.HeaderText = "Fecha A";
            this.fechaa.Name = "fechaa";
            this.fechaa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechaa.Visible = false;
            // 
            // minu
            // 
            this.minu.DataPropertyName = "minutos";
            this.minu.HeaderText = "muni";
            this.minu.Name = "minu";
            this.minu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.minu.Visible = false;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "Categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.categoria.Visible = false;
            // 
            // frmSolicitudes_Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 322);
            this.Controls.Add(this.dtgSolicitudes_Prestamo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSolicitudes_Prestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes de Prestamo";
            this.Load += new System.EventHandler(this.frmSolicitudes_Devolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolicitudes_Prestamo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.DataGridView dtgSolicitudes_Prestamo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarSolicitud;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dtgLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaEs;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autoriazado;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadev;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn minu;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
    }
}