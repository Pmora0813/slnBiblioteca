namespace Capa.UI.Mantenimientos
{
    partial class frmBuscarAutores
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lstAutores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(47, 182);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 29);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lstAutores
            // 
            this.lstAutores.BackColor = System.Drawing.SystemColors.Info;
            this.lstAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAutores.FormattingEnabled = true;
            this.lstAutores.ItemHeight = 16;
            this.lstAutores.Location = new System.Drawing.Point(12, 12);
            this.lstAutores.Name = "lstAutores";
            this.lstAutores.Size = new System.Drawing.Size(140, 164);
            this.lstAutores.TabIndex = 2;
            // 
            // frmBuscarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 219);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lstAutores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autores";
            this.Load += new System.EventHandler(this.frmBuscarAutores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox lstAutores;
    }
}