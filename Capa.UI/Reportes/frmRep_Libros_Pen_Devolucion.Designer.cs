namespace Capa.UI.Reportes
{
    partial class frmRep_Libros_Pen_Devolucion
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
            this.bibliotecaDataSet1 = new Capa.UI.BibliotecaDataSet1();
            this.rEPLIBROSPENDIENTESDEVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEP_LIBROS_PENDIENTES_DEVTableAdapter = new Capa.UI.BibliotecaDataSet1TableAdapters.REP_LIBROS_PENDIENTES_DEVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPLIBROSPENDIENTESDEVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsLibros_Pen_Devolucion";
            reportDataSource1.Value = this.rEPLIBROSPENDIENTESDEVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.Reportes.RepLibros_Pen_Devolucion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(835, 377);
            this.reportViewer1.TabIndex = 0;
            // 
            // bibliotecaDataSet1
            // 
            this.bibliotecaDataSet1.DataSetName = "BibliotecaDataSet1";
            this.bibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEPLIBROSPENDIENTESDEVBindingSource
            // 
            this.rEPLIBROSPENDIENTESDEVBindingSource.DataMember = "REP_LIBROS_PENDIENTES_DEV";
            this.rEPLIBROSPENDIENTESDEVBindingSource.DataSource = this.bibliotecaDataSet1;
            // 
            // rEP_LIBROS_PENDIENTES_DEVTableAdapter
            // 
            this.rEP_LIBROS_PENDIENTES_DEVTableAdapter.ClearBeforeFill = true;
            // 
            // frmRep_Libros_Pen_Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 377);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRep_Libros_Pen_Devolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros Pendiente de Devolucion";
            this.Load += new System.EventHandler(this.frmRep_Libros_Pen_Devolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPLIBROSPENDIENTESDEVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BibliotecaDataSet1 bibliotecaDataSet1;
        private System.Windows.Forms.BindingSource rEPLIBROSPENDIENTESDEVBindingSource;
        private BibliotecaDataSet1TableAdapters.REP_LIBROS_PENDIENTES_DEVTableAdapter rEP_LIBROS_PENDIENTES_DEVTableAdapter;
    }
}