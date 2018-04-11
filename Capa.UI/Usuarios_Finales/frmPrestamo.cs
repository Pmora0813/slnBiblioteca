using Capa.Entidades;
using Capa.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Usuarios_Finales
{
    public partial class frmPrestamo : Form
    {
        private Estudiante_Logica Logica = null;
        public Prestamo_Logica Prest_Logica = null;
        public Prestamo_Libros_Logica PreLib_Logica = null;
        private Estudiante estudiante = null;
        private Libros Libro = null;
        private Prestamo Prestamo = null;
        public Usuario Usuario { get; set; }
        public frmPrestamo()
        {
            InitializeComponent();
            Logica = new Estudiante_Logica();
            Prest_Logica = new Prestamo_Logica();
            PreLib_Logica = new Prestamo_Libros_Logica();
        }

        private void btnBuscar_est_Click(object sender, EventArgs e)
        {
            Buscarestudiante();
        }

        private void Buscarestudiante()
        {
            try
            {
                if (mskCedula_estudiant.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese la Cedula del Estudiante", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                estudiante = new Estudiante_Logica().SeleccionarEstudiantePorId(Convert.ToInt32(mskCedula_estudiant.Text));

                txtNombre_est.Text = estudiante.Nombre;
                txtSeccion_est.Text = estudiante.Seccion;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            mskCedula_estudiant.Text = "115100427";
            mskCodigo_Libro.Text = "1";
            try
            {
                txtCodigo_Prestamo.Text = DateTime.Now.Ticks.ToString().Substring(12, 6);

                dtpFechaAct.Value = Prest_Logica.ObtenerFecha();
                txtUsuario.Text = this.Usuario.id.ToString();

                cmbTipoSolicitud.DataSource = new Categoira_Logica().SeleccionarTodos();
                cmbTipoSolicitud.DisplayMember = "Descripcion";
                cmbTipoSolicitud.ValueMember = "Id";
                cmbTipoSolicitud.SelectedIndex = -1;

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarLibro();
        }

        private void BuscarLibro()
        {
            try
            {
                if (mskCodigo_Libro.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese el Codigo del Libro", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Libro = new Libro_Logica().SeleccionarPorID(Convert.ToInt32(mskCodigo_Libro.Text));


                txtTitulo.Text = Libro.Titulo;
                txtAnno.Text = Libro.anno.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Prestamo = new Prestamo()
                {
                    id = Convert.ToInt32(txtCodigo_Prestamo.Text),
                    Fecha_Act = dtpFechaAct.Value,
                    Fecha_Dev = dtpFecha_Dev.Value,
                    dias = Convert.ToInt32(dtpFecha_Dev.Value.Day - dtpFechaAct.Value.Day),
                    horas = Convert.ToInt32(dtpFecha_Dev.Value.Hour - dtpFechaAct.Value.Hour),
                    minutos = Convert.ToInt32(dtpFecha_Dev.Value.Minute - dtpFechaAct.Value.Minute),
                    estudiant = estudiante,
                    //Libro = Libro,
                    Usuario = Usuario,
                    Categoria = (Categoria)cmbTipoSolicitud.SelectedItem
                };

                Prest_Logica.guardar(Prestamo);
                MessageBox.Show("Se registro un Prestamo con exito", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                throw;
            }
            //Mostrar_Prestamo();


        }
        //Metodo para cargar el XML y mostrarlo en el webbroser
        private void Mostrar_Prestamo()
        {
            string ruta = Prest_Logica.Ruta;

            Prest_Logica.GuardarXML(Prestamo, ruta);
            //Transformanos el archivo XML en HTML con el metodo
            ruta = Prest_Logica.TransformXMLToHTML(ruta);

            //Le asignamos el HTML al web broser
            wbbMostrar.Url = new Uri(Application.StartupPath + "\\" + ruta);
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop );
            saveFileDialog.Filter = "Archivos de texto (*.pdf)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }

            //string nombreArchivo = Prest_Logica.RutaPDF + Guid.NewGuid().ToString() + ".pdf";

        }

        private void mskCedula_estudiant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscarestudiante();
            }
        }

        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            frmBuscar_Estudiante ofrm = new frmBuscar_Estudiante();
            ofrm.ShowDialog();
            estudiante = null;

            estudiante = ofrm.estudiante;

            if (estudiante != null)
            {
                mskCedula_estudiant.Text = estudiante.IdCedula.ToString();
                txtNombre_est.Text = estudiante.Nombre;
                txtSeccion_est.Text = estudiante.Seccion;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscar_Libro ofrm = new frmBuscar_Libro();
            ofrm.ShowDialog();

            Libro = ofrm.Libro;
            if (Libro!=null)
            {
                mskCodigo_Libro.Text = Libro.Id.ToString();
                txtTitulo.Text = Libro.Titulo;
                txtAnno.Text = Libro.anno.ToString();                     
            }
        }

        private void mskCodigo_Libro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarLibro();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                PreLib_Logica.guardar(Prestamo, Libro);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

