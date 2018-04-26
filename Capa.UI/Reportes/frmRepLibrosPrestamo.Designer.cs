namespace Capa.UI.Reportes
{
    partial class frmRepLibrosPrestamo
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
            this.bibliotecaDataSet3 = new Capa.UI.BibliotecaDataSet3();
            this.rEPLIBROSPRESTAMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEP_LIBROS_PRESTAMOTableAdapter = new Capa.UI.BibliotecaDataSet3TableAdapters.REP_LIBROS_PRESTAMOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPLIBROSPRESTAMOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsLibrosporPrestamo";
            reportDataSource1.Value = this.rEPLIBROSPRESTAMOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.RepLibrosporPrestamo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(880, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // bibliotecaDataSet3
            // 
            this.bibliotecaDataSet3.DataSetName = "BibliotecaDataSet3";
            this.bibliotecaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEPLIBROSPRESTAMOBindingSource
            // 
            this.rEPLIBROSPRESTAMOBindingSource.DataMember = "REP_LIBROS_PRESTAMO";
            this.rEPLIBROSPRESTAMOBindingSource.DataSource = this.bibliotecaDataSet3;
            // 
            // rEP_LIBROS_PRESTAMOTableAdapter
            // 
            this.rEP_LIBROS_PRESTAMOTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepLibrosPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 396);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRepLibrosPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Libros Prestados";
            this.Load += new System.EventHandler(this.frmRepLibrosPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPLIBROSPRESTAMOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BibliotecaDataSet3 bibliotecaDataSet3;
        private System.Windows.Forms.BindingSource rEPLIBROSPRESTAMOBindingSource;
        private BibliotecaDataSet3TableAdapters.REP_LIBROS_PRESTAMOTableAdapter rEP_LIBROS_PRESTAMOTableAdapter;
    }
}