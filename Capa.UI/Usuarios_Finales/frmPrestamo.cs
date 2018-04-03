using Capa.Entidades;
using Capa.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private Estudiante estudiante = null;
        private Libros Libro = null;
        public Usuario Usuario { get; set; }
        public frmPrestamo()
        {
            InitializeComponent();
            Logica = new Estudiante_Logica();
            Prest_Logica = new Prestamo_Logica();
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

        private void lblBus_Avanzada_Click(object sender, EventArgs e)
        {
            frmBuscar_Estudiante ofrm = new frmBuscar_Estudiante();
            ofrm.ShowDialog();

            estudiante = ofrm.estudiante;
            mskCedula_estudiant.Text = estudiante.IdCedula.ToString();
            txtNombre_est.Text = estudiante.Nombre;
            txtSeccion_est.Text = estudiante.Seccion;


        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            try
            {
                txtCodigo_Prestamo.Text = DateTime.Now.Millisecond.ToString();

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

        private void lblBuscar_Libros_Click(object sender, EventArgs e)
        {
            frmBuscar_Libro ofrm = new frmBuscar_Libro();
            ofrm.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Prestamo Prestamo = new Prestamo()
                {
                    //id = Convert.ToInt32(txtCodigo_Prestamo.Text),
                    Fecha_Act = dtpFechaAct.Value,
                    Fecha_Dev = dtpFecha_Dev.Value,
                    dias = Convert.ToInt32(dtpFecha_Dev.Value.Day - dtpFechaAct.Value.Day),
                    horas = Convert.ToInt32(dtpFecha_Dev.Value.Hour),
                    minutos = Convert.ToInt32(dtpFecha_Dev.Value.Minute),
                    estudiant = estudiante,
                    Libro = Libro,
                    Usuario = Usuario,
                    Categoria = (Categoria) cmbTipoSolicitud.SelectedItem
                };

                Prest_Logica.guardar(Prestamo);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
