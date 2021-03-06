﻿namespace Capa.UI.Mantenimientos
{
    partial class frmMant_Usuario
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
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasenna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskUsuaro = new System.Windows.Forms.MaskedTextBox();
            this.mskContrasenna = new System.Windows.Forms.MaskedTextBox();
            this.Categoria = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Contrasenna,
            this.id_Rol});
            this.dtgUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgUsuarios.Location = new System.Drawing.Point(13, 213);
            this.dtgUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dtgUsuarios.MultiSelect = false;
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuarios.Size = new System.Drawing.Size(312, 152);
            this.dtgUsuarios.TabIndex = 13;
            this.dtgUsuarios.SelectionChanged += new System.EventHandler(this.dtgUsuarios_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Cedula";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Contrasenna
            // 
            this.Contrasenna.DataPropertyName = "Contrasenna";
            this.Contrasenna.HeaderText = "Column1";
            this.Contrasenna.Name = "Contrasenna";
            this.Contrasenna.ReadOnly = true;
            this.Contrasenna.Visible = false;
            // 
            // id_Rol
            // 
            this.id_Rol.DataPropertyName = "Rol";
            this.id_Rol.HeaderText = "Tipo";
            this.id_Rol.Name = "id_Rol";
            this.id_Rol.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::Capa.UI.Properties.Resources.trashcan_full48;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.Location = new System.Drawing.Point(205, 151);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 54);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::Capa.UI.Properties.Resources.floppy48;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.Location = new System.Drawing.Point(13, 151);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 54);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            // 
            // mskUsuaro
            // 
            this.mskUsuaro.Location = new System.Drawing.Point(118, 12);
            this.mskUsuaro.Mask = "0-0000-0000";
            this.mskUsuaro.Name = "mskUsuaro";
            this.mskUsuaro.Size = new System.Drawing.Size(93, 23);
            this.mskUsuaro.TabIndex = 14;
            this.mskUsuaro.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskContrasenna
            // 
            this.mskContrasenna.Location = new System.Drawing.Point(118, 53);
            this.mskContrasenna.Name = "mskContrasenna";
            this.mskContrasenna.PasswordChar = '*';
            this.mskContrasenna.Size = new System.Drawing.Size(128, 23);
            this.mskContrasenna.TabIndex = 15;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Location = new System.Drawing.Point(17, 103);
            this.Categoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(69, 17);
            this.Categoria.TabIndex = 16;
            this.Categoria.Text = "Categoría";
            // 
            // cmbRoles
            // 
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(118, 95);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(126, 25);
            this.cmbRoles.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Capa.UI.Properties.Resources.contact48;
            this.panel1.Location = new System.Drawing.Point(273, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 49);
            this.panel1.TabIndex = 18;
            // 
            // frmMant_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(352, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.mskContrasenna);
            this.Controls.Add(this.mskUsuaro);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMant_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmMant_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskUsuaro;
        private System.Windows.Forms.MaskedTextBox mskContrasenna;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasenna;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Rol;
        private System.Windows.Forms.Panel panel1;
    }
}