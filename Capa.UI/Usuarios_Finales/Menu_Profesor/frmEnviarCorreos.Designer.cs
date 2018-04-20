namespace Capa.UI.Usuarios_Finales.Menu_Profesor
{
    partial class frmEnviarCorreos
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
            this.btnabrir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtadjuntos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbmensaje = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnabrir
            // 
            this.btnabrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnabrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrir.Location = new System.Drawing.Point(397, 26);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(55, 26);
            this.btnabrir.TabIndex = 17;
            this.btnabrir.Text = "...";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Archivos adjuntos (separados por \'|\'):";
            // 
            // txtadjuntos
            // 
            this.txtadjuntos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtadjuntos.Location = new System.Drawing.Point(15, 28);
            this.txtadjuntos.Name = "txtadjuntos";
            this.txtadjuntos.ReadOnly = true;
            this.txtadjuntos.Size = new System.Drawing.Size(376, 22);
            this.txtadjuntos.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mensaje:";
            // 
            // rtbmensaje
            // 
            this.rtbmensaje.Location = new System.Drawing.Point(20, 87);
            this.rtbmensaje.Name = "rtbmensaje";
            this.rtbmensaje.Size = new System.Drawing.Size(432, 103);
            this.rtbmensaje.TabIndex = 18;
            this.rtbmensaje.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Capa.UI.Properties.Resources.sign_out;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(367, 196);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 50);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackgroundImage = global::Capa.UI.Properties.Resources.send_48;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnviar.Location = new System.Drawing.Point(255, 196);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(106, 50);
            this.btnEnviar.TabIndex = 22;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmEnviarCorreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 280);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbmensaje);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtadjuntos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnviarCorreos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar Correos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtadjuntos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbmensaje;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}