namespace Capa.UI.Reportes
{
    partial class frmRepLibros_Mas_Prestados
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
            this.tOP5LIBROSMASPRESTADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet2 = new Capa.UI.BibliotecaDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tOP_5_LIBROS_MAS_PRESTADOSTableAdapter = new Capa.UI.BibliotecaDataSet2TableAdapters.TOP_5_LIBROS_MAS_PRESTADOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tOP5LIBROSMASPRESTADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tOP5LIBROSMASPRESTADOSBindingSource
            // 
            this.tOP5LIBROSMASPRESTADOSBindingSource.DataMember = "TOP_5_LIBROS_MAS_PRESTADOS";
            this.tOP5LIBROSMASPRESTADOSBindingSource.DataSource = this.bibliotecaDataSet2;
            // 
            // bibliotecaDataSet2
            // 
            this.bibliotecaDataSet2.DataSetName = "BibliotecaDataSet2";
            this.bibliotecaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tOP5LIBROSMASPRESTADOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.RepLibros+Prestados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(764, 321);
            this.reportViewer1.TabIndex = 0;
            // 
            // tOP_5_LIBROS_MAS_PRESTADOSTableAdapter
            // 
            this.tOP_5_LIBROS_MAS_PRESTADOSTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepLibros_Mas_Prestados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 321);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRepLibros_Mas_Prestados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Libros más Prestados";
            this.Load += new System.EventHandler(this.frmRepLibros_Mas_Prestados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tOP5LIBROSMASPRESTADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BibliotecaDataSet2 bibliotecaDataSet2;
        private System.Windows.Forms.BindingSource tOP5LIBROSMASPRESTADOSBindingSource;
        private BibliotecaDataSet2TableAdapters.TOP_5_LIBROS_MAS_PRESTADOSTableAdapter tOP_5_LIBROS_MAS_PRESTADOSTableAdapter;
    }
}