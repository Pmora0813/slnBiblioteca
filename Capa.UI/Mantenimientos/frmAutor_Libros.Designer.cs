namespace Capa.UI.Mantenimientos
{
    partial class frmLibros_Autores
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
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.btnMostra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgLibros_Autores = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros_Autores)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLibros
            // 
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(57, 20);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(142, 24);
            this.cmbLibros.TabIndex = 0;
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(211, 20);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(79, 24);
            this.btnMostra.TabIndex = 1;
            this.btnMostra.Text = "Mostrar";
            this.btnMostra.UseVisualStyleBackColor = true;
            this.btnMostra.Click += new System.EventHandler(this.btnMostra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Libros";
            // 
            // dtgLibros_Autores
            // 
            this.dtgLibros_Autores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLibros_Autores.Location = new System.Drawing.Point(12, 97);
            this.dtgLibros_Autores.MultiSelect = false;
            this.dtgLibros_Autores.Name = "dtgLibros_Autores";
            this.dtgLibros_Autores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLibros_Autores.Size = new System.Drawing.Size(279, 218);
            this.dtgLibros_Autores.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(211, 50);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 24);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmLibros_Autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(302, 318);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtgLibros_Autores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostra);
            this.Controls.Add(this.cmbLibros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLibros_Autores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros por Autores";
            this.Load += new System.EventHandler(this.frmLibros_Autores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros_Autores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgLibros_Autores;
        private System.Windows.Forms.Button btnEliminar;
    }
}