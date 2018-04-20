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
    public partial class frmMant_Libros : Form
    {

        private string escuela = "Escuela Platanares";
        Libro_Logica Logica = null;

        public frmMant_Libros()
        {
            InitializeComponent();
            Logica = new Libro_Logica();
        }

        private void frmMant_Libros_Load(object sender, EventArgs e)
        {

            try
            {
                Refrescar();
                llenarComboEditoriales();
                llenarComboAutores();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refrescar()
        {
            dtgLibros.DataSource = Logica.SeleccionarTodos();
        }

        private void llenarComboAutores()
        {
            Autor_Logica Logica = new Autor_Logica();
            cbmAutores.DataSource = Logica.SeleccionarTodos();
        }

        private void llenarComboEditoriales()
        {
            Editorial_Logica logica = new Editorial_Logica();
            cbmEditoriales.DataSource = logica.SeleccionarTodos();
            cbmEditoriales.DisplayMember = "Nombre";
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Libros libro = new Libros()
                {
                    Id = Convert.ToInt32(txtCodigo.Text),
                    Titulo = txtNombre.Text,
                    anno = Convert.ToInt32(mskAnno.Text),
                    Editorial = (Editorial)cbmEditoriales.SelectedItem

                };

                QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                QrCode qrCode = new QrCode();
                qrEncoder.TryEncode(txtCodigo.Text, out qrCode);

                GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                MemoryStream ms = new MemoryStream();

                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
                var imageTemporal = new Bitmap(ms);
                var imagen = new Bitmap(imageTemporal, new Size(new Point(145, 125)));
                QR.BackgroundImage = imagen;

                libro.Qr = imagen.ToString();

                // Guardar en el disco duro la imagen (Carpeta del proyecto)
                //imagen.Save("imagen.png", ImageFormat.Png);
                // btnEliminar.Enabled = true;
                Logica.Insertar(libro);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Refrescar();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(" "))
            {
                MessageBox.Show("No hay Libros para Eliminar", escuela, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            try
            {
                DialogResult resultado = MessageBox.Show("Esta Seguro?", escuela, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Logica.Eliminar(Convert.ToInt32(txtCodigo.Text));
                    MessageBox.Show("Libro eliminado con Exito", escuela, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Refrescar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgLibros_SelectionChanged(object sender, EventArgs e)
        {

            if (dtgLibros.SelectedRows.Count > 0)
            {
                Libros libro = (Libros)dtgLibros.SelectedRows[0].DataBoundItem;
                txtCodigo.Text = libro.Id.ToString();
                txtNombre.Text = libro.Titulo;
                mskAnno.Text = libro.anno.ToString();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmLibros_Autores ofrm = new frmLibros_Autores();

            ofrm.Show();
        }
    }
}
