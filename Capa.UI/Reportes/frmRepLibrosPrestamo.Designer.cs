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
            this.bibliotecaDataSet = new Capa.UI.BibliotecaDataSet();
            this.rEPLIBROSPRESTAMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEP_LIBROS_PRESTAMOTableAdapter = new Capa.UI.BibliotecaDataSetTableAdapters.REP_LIBROS_PRESTAMOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPLIBROSPRESTAMOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsLibrosPrestamo";
            reportDataSource1.Value = this.rEPLIBROSPRESTAMOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.RepLibrosPrestamo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(880, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEPLIBROSPRESTAMOBindingSource
            // 
            this.rEPLIBROSPRESTAMOBindingSource.DataMember = "REP_LIBROS_PRESTAMO";
            this.rEPLIBROSPRESTAMOBindingSource.DataSource = this.bibliotecaDataSet;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRepLibrosPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Libros Prestados";
            this.Load += new System.EventHandler(this.frmRepLibrosPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPLIBROSPRESTAMOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource rEPLIBROSPRESTAMOBindingSource;
        private BibliotecaDataSetTableAdapters.REP_LIBROS_PRESTAMOTableAdapter rEP_LIBROS_PRESTAMOTableAdapter;
    }
}