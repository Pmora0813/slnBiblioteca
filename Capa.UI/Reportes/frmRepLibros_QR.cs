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
    public partial class frmRepLibros_QR : Form
    {
        public List<Libros> Lista { get; set; }
        public frmRepLibros_QR()
        {
            InitializeComponent();

        }

        private void frmRepLibros_QR_Load(object sender, EventArgs e)
        {


            List<Libros> Lista_L = new List<Libros>();
            foreach (Libros item in Lista)
            {


                QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                QrCode qrCode = new QrCode();
                qrEncoder.TryEncode(item.Id.ToString(), out qrCode);

                GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                MemoryStream ms = new MemoryStream();

                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
                var imageTemporal = new Bitmap(ms);
                var imagen = new Bitmap(imageTemporal, new Size(new Point(145, 125)));
                ImageConverter converter = new ImageConverter();
                item.Codigo = (byte[])converter.ConvertTo(imagen, typeof(byte[]));                
                Lista_L.Add(item);

            }
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsLibros_QR", Lista_L));
            this.reportViewer1.RefreshReport();
        }
    }
}
