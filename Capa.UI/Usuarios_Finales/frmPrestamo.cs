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
            if (!txtSeccion_est.Text.Equals(""))
            {
                MessageBox.Show("Estudiante encontrado", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Buscarestudiante();
        }

        private void Buscarestudiante()
        {
            try
            {
                if (mskCedula_estudiant.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese la Cedula del Estudiante", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmbTipoSolicitud.SelectedIndex = 0;
                cmbTipoSolicitud.Enabled = false;

                Prest_Logica.CrearCarpeta();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!txtTitulo.Text.Equals(""))
            {
                MessageBox.Show("Libro encontrado", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BuscarLibro();
        }

        private void BuscarLibro()
        {
            try
            {
                if (mskCodigo_Libro.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese el Codigo del Libro", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (mskCedula_estudiant.Text.Equals(""))
            {
                MessageBox.Show("Ingrese la Cedula del Estudiante", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (estudiante == null)
            {
                MessageBox.Show("Seleccione un Estudiante para el Prestamo", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Usuario == null)
            {
                MessageBox.Show("Seleccione un Usuario no Autorizado", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbTipoSolicitud.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una Categoria para el Prestamo", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            Mostrar_Prestamo();

        }
        //Metodo para cargar el XML y mostrarlo en el webbroser
        private void Mostrar_Prestamo()
        {
            string ruta = Prest_Logica.Ruta + "_" + Prestamo.id + ".xml";
            Prest_Logica.GuardarXML(Prestamo, ruta);
            //Transformanos el archivo XML en HTML con el metodo
            string html = Prest_Logica.Ruta + "_" + Prestamo.id + ".html"; ;
            ruta = Prest_Logica.TransformXMLToHTML(ruta, html);

            //Le asignamos el HTML al web broser
            wbbMostrar.Url = new Uri(Application.StartupPath + "\\" + ruta);

        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            if (estudiante != null)
            {
                try
                {
                    Menu_Profesor.frmEnviarCorreos ofrm = new Menu_Profesor.frmEnviarCorreos();
                    ofrm.Estudiante = estudiante;
                    ofrm.ShowDialog();
                }
                catch (Exception)
                {

                    throw;
                }
            }
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
            if (Libro != null)
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
            if (mskCodigo_Libro.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el Codigo del Libro", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (Libro == null)
                {
                    MessageBox.Show("Seleccione un Libro para el Prestamo", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Prestamo == null)
                {
                    MessageBox.Show("No se a registrado un Prestamo", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                PreLib_Logica.guardar(Prestamo, Libro);
                MessageBox.Show("Se agrego un Libro para el Prestamo", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Se agrego esté Libro para el Prestamo", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Mostrar_Prestamo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void mskCedula_estudiant_TextChanged(object sender, EventArgs e)
        {
            if (mskCedula_estudiant.Text.Equals(""))
            {
                txtNombre_est.Text = "";
                txtSeccion_est.Text = "";
            }
        }

        private void mskCodigo_Libro_TextChanged(object sender, EventArgs e)
        {
            if (mskCodigo_Libro.Text.Equals(""))
            {
                txtTitulo.Text = "";
                txtAnno.Text = "";
            }
        }
    }
}

