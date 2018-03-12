namespace Capa.UI
{
    partial class frmPrincipal
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
            this.btnMant_Autor = new System.Windows.Forms.Button();
            this.btnMant_Editorial = new System.Windows.Forms.Button();
            this.btnMant_Libros = new System.Windows.Forms.Button();
            this.btnMant_Categorias = new System.Windows.Forms.Button();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMant_Autor
            // 
            this.btnMant_Autor.Location = new System.Drawing.Point(16, 15);
            this.btnMant_Autor.Margin = new System.Windows.Forms.Padding(4);
            this.btnMant_Autor.Name = "btnMant_Autor";
            this.btnMant_Autor.Size = new System.Drawing.Size(215, 41);
            this.btnMant_Autor.TabIndex = 0;
            this.btnMant_Autor.Text = "Autores";
            this.btnMant_Autor.UseVisualStyleBackColor = true;
            this.btnMant_Autor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMant_Editorial
            // 
            this.btnMant_Editorial.Location = new System.Drawing.Point(16, 112);
            this.btnMant_Editorial.Margin = new System.Windows.Forms.Padding(4);
            this.btnMant_Editorial.Name = "btnMant_Editorial";
            this.btnMant_Editorial.Size = new System.Drawing.Size(215, 41);
            this.btnMant_Editorial.TabIndex = 1;
            this.btnMant_Editorial.Text = "Editoriales";
            this.btnMant_Editorial.UseVisualStyleBackColor = true;
            this.btnMant_Editorial.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMant_Libros
            // 
            this.btnMant_Libros.Location = new System.Drawing.Point(16, 161);
            this.btnMant_Libros.Margin = new System.Windows.Forms.Padding(4);
            this.btnMant_Libros.Name = "btnMant_Libros";
            this.btnMant_Libros.Size = new System.Drawing.Size(215, 41);
            this.btnMant_Libros.TabIndex = 2;
            this.btnMant_Libros.Text = "Libros";
            this.btnMant_Libros.UseVisualStyleBackColor = true;
            this.btnMant_Libros.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMant_Categorias
            // 
            this.btnMant_Categorias.Location = new System.Drawing.Point(16, 64);
            this.btnMant_Categorias.Margin = new System.Windows.Forms.Padding(4);
            this.btnMant_Categorias.Name = "btnMant_Categorias";
            this.btnMant_Categorias.Size = new System.Drawing.Size(215, 41);
            this.btnMant_Categorias.TabIndex = 3;
            this.btnMant_Categorias.Text = "Categorias";
            this.btnMant_Categorias.UseVisualStyleBackColor = true;
            this.btnMant_Categorias.Click += new System.EventHandler(this.btnMant_Categorias_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Location = new System.Drawing.Point(239, 15);
            this.btnEstudiantes.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(215, 41);
            this.btnEstudiantes.TabIndex = 4;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(239, 64);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(215, 41);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 210);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnEstudiantes);
            this.Controls.Add(this.btnMant_Categorias);
            this.Controls.Add(this.btnMant_Libros);
            this.Controls.Add(this.btnMant_Editorial);
            this.Controls.Add(this.btnMant_Autor);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimientos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMant_Autor;
        private System.Windows.Forms.Button btnMant_Editorial;
        private System.Windows.Forms.Button btnMant_Libros;
        private System.Windows.Forms.Button btnMant_Categorias;
        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Button btnUsuarios;
    }
}