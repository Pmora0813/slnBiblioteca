namespace Capa.UI.Reportes
{
    partial class frmRep_Estudiantes_QR
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsEstudiantesQR";
            reportDataSource1.Value = this.estudianteBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.Rep_EstudiantesQR.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(530, 408);
            this.reportViewer1.TabIndex = 0;
            // 
            // EstudianteBindingSource
            // 
            this.EstudianteBindingSource.DataSource = typeof(Capa.Entidades.Estudiante);
            // 
            // estudianteBindingSource1
            // 
            this.estudianteBindingSource1.DataSource = typeof(Capa.Entidades.Estudiante);
            // 
            // frmRep_Estudiantes_QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 408);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRep_Estudiantes_QR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Estudiantes QR";
            this.Load += new System.EventHandler(this.frmRep_Estudiantes_QR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EstudianteBindingSource;
        private System.Windows.Forms.BindingSource estudianteBindingSource1;
    }
}