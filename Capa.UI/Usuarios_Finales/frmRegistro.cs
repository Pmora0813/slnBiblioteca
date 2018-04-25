using Capa.Entidades;
using Capa.Logica;
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

namespace Capa.UI.Usuarios_Finales
{
    public partial class frmRegistro : Form
    {
        private string escuela = "Escuela Platanares";
        Estudiante_Logica Logica = null;

        public frmRegistro()
        {
            InitializeComponent();
            Logica = new Estudiante_Logica();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                Estudiante estudiante = new Estudiante()
                {
                    IdCedula = Convert.ToInt32(mskCedula.Text),
                    Nombre = txtNombre.Text,
                    Email = txtEmai.Text,
                    Seccion = txtSeccion.Text,
                    F_Nacimiento = Convert.ToDateTime(dtpF_Nacimiento.Value),
                    Telefono = Convert.ToInt32(mskTelefono.Text),
                    Activo = true,
                    Roll = new Rol_Logica().SeleccionarRollPorId(Convert.ToInt32("3"))
                };
                if (rbtnMasculino.Checked)
                {
                    estudiante.Genero = "Masculino";
                }

                if (rbtnFemenino.Checked)
                {
                    estudiante.Genero = "Femenino";
                }
                estudiante.Contrasenna = estudiante.IdCedula.ToString().Substring(0, 4) + estudiante.Nombre.Substring(0, 4);

                QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                QrCode qrCode = new QrCode();
                qrEncoder.TryEncode(mskCedula.Text, out qrCode);

                GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                MemoryStream ms = new MemoryStream();

                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
                var imageTemporal = new Bitmap(ms);
                var imagen = new Bitmap(imageTemporal, new Size(new Point(145, 125)));
                panel1.BackgroundImage = imagen;

                ImageConverter converter = new ImageConverter();
                estudiante.QR = (byte[])converter.ConvertTo(imagen, typeof(byte[]));


                Logica.guardar(estudiante);

                MessageBox.Show("Estudiante guardado con Exito", escuela, MessageBoxButtons.OK, MessageBoxIcon.Information);

                string folderName = @"C:\Users\Pablo\Desktop\Codigos QR";
                string pathString = System.IO.Path.Combine(folderName);

                if (System.IO.Directory.Exists(pathString) != true)
                {
                    System.IO.Directory.CreateDirectory(pathString);
                    imagen.Save("C:\\Users\\Pablo\\Desktop\\Codigos QR\\" + estudiante.IdCedula + ".png", ImageFormat.Png);
                }
                else
                {
                    imagen.Save("C:\\Users\\Pablo\\Desktop\\Codigos QR\\" + estudiante.IdCedula + ".png", ImageFormat.Png);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }

        private void txtEmai_TextChanged(object sender, EventArgs e)
        {
            if (Logica.ComprobarFormatoEmail(txtEmai.Text) == false)
            {
                txtEmai.ForeColor = Color.Red;
            }
            else
            {
                txtEmai.ForeColor = Color.Green;
            }
            //txtEmai.ForeColor = Color.Black;
        }
    }
}
