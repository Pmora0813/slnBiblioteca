using Capa.Entidades;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Reportes
{
    public partial class frmRep_Estudiantes_QR : Form
    {
        public List<Estudiante> lista { get; set; }
        public frmRep_Estudiantes_QR()
        {
            InitializeComponent();
        }

        private void frmRep_Estudiantes_QR_Load(object sender, EventArgs e)
        {

            List<Estudiante> Lista_P = new List<Estudiante>();
            foreach (Estudiante item in lista)
            {


                QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                QrCode qrCode = new QrCode();
                qrEncoder.TryEncode(item.IdCedula.ToString(), out qrCode);

                GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                MemoryStream ms = new MemoryStream();

                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
                var imageTemporal = new Bitmap(ms);
                var imagen = new Bitmap(imageTemporal, new Size(new Point(145, 125)));
                ImageConverter converter = new ImageConverter();
                item.QR = (byte[])converter.ConvertTo(imagen, typeof(byte[]));
                Lista_P.Add(item);

            }
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsEstudiantesQR", Lista_P));
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
