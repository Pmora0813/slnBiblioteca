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

namespace Capa.UI.Mantenimientos
{
    public partial class frmMant_Estudiante : Form
    {
        private string escuela = "Escuela Platanares";
        Estudiante_Logica Logica = null;

        public frmMant_Estudiante()
        {
            InitializeComponent();
            Logica = new Estudiante_Logica();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                char genero = ' ';

                if (rbtnMasculino.Checked)
                {
                    genero = 'M';
                }
                else
                {
                    genero = 'F';
                }
                Estudiante estudiante = new Estudiante()
                {
                    IdCedula = Convert.ToInt32(mskCedula.Text),
                    Nombre = txtNombre.Text,
                    Email = txtEmai.Text,
                    Seccion = txtSeccion.Text,
                    Genero = genero,
                    F_Nacimiento = Convert.ToDateTime(dtpF_Nacimiento.Value),
                    Telefono = Convert.ToInt32(mskTelefono.Text),
                    Activo = chkActivo.Checked,
                    Roll = new Rol_Logica().SeleccionarRollPorId(Convert.ToInt32("3"))
                };
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

                estudiante.QR = imagen.ToString();


                Logica.guardar(estudiante);
                Refrescar();
                MessageBox.Show("Estudiante guardado con Exito", escuela, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("La contraseña del estudiante es " + estudiante.Contrasenna, "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Guardar en el disco duro la imagen (Carpeta del proyecto)
            //imagen.Save("imagen.png", ImageFormat.Png);

        }

        private void frmMant_Estudiante_Load(object sender, EventArgs e)
        {

            try
            {
                Refrescar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refrescar()
        {
            dtgEstudiantes.DataSource = Logica.SeleccionarTodos();
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (mskCedula.Text.Length <= 0)
            {
                MessageBox.Show("No hay Estudiantes para Eliminar", escuela, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            try
            {
                DialogResult resultado = MessageBox.Show("Esta Seguro?", escuela, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Logica.Eliminar(Convert.ToInt32(mskCedula.Text));
                    MessageBox.Show("Estudiante eliminado con Exito", escuela, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Refrescar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgEstudiantes_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgEstudiantes.SelectedRows.Count > 0)
            {
                Estudiante est = (Estudiante)dtgEstudiantes.SelectedRows[0].DataBoundItem;
                mskCedula.Text = est.IdCedula.ToString();
                txtNombre.Text = est.Nombre;
            }
        }
    }
}
