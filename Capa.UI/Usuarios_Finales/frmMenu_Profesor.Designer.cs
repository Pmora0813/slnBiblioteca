namespace Capa.UI.Usuarios_Finales
{
    partial class frmMenu_Profesor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu_Profesor));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnRealiazar_Devol = new System.Windows.Forms.Button();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackgroundImage = global::Capa.UI.Properties.Resources.administrative_docs;
            this.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(839, 26);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(210, 40);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "Registro de Solicitudes";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnRealiazar_Devol
            // 
            this.btnRealiazar_Devol.BackgroundImage = global::Capa.UI.Properties.Resources.document_library1;
            this.btnRealiazar_Devol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRealiazar_Devol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRealiazar_Devol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealiazar_Devol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealiazar_Devol.Location = new System.Drawing.Point(563, 26);
            this.btnRealiazar_Devol.Name = "btnRealiazar_Devol";
            this.btnRealiazar_Devol.Size = new System.Drawing.Size(203, 40);
            this.btnRealiazar_Devol.TabIndex = 1;
            this.btnRealiazar_Devol.Text = "Realizar Devoluciones";
            this.btnRealiazar_Devol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRealiazar_Devol.UseVisualStyleBackColor = true;
            this.btnRealiazar_Devol.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.BackgroundImage = global::Capa.UI.Properties.Resources.issue1;
            this.btnSolicitudes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSolicitudes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitudes.Location = new System.Drawing.Point(309, 26);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(181, 40);
            this.btnSolicitudes.TabIndex = 0;
            this.btnSolicitudes.Text = "Realizar Prestamo";
            this.btnSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSolicitudes.UseVisualStyleBackColor = true;
            this.btnSolicitudes.Click += new System.EventHandler(this.btnSolicitudes_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSolicitudes);
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.btnRealiazar_Devol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 84);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmMenu_Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1254, 525);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu_Profesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Profesor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_Profesor_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Profesor_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnRealiazar_Devol;
        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Panel panel1;
    }
}



