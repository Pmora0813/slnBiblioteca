using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Reportes
{
    public partial class frmRep_Libros_Estudiantes : Form
    {
        List<Libros> Lista_Libros = null;
        List<Libros> Otros_Libros = null;
        List<Estudiante> Lista_Estiduantes = null;
        List<Estudiante> Otros_Estudiantes = null;
        public frmRep_Libros_Estudiantes()
        {
            InitializeComponent();
            Lista_Libros = new List<Libros>();
            Lista_Estiduantes = new List<Estudiante>();
        }

        private void frmRep_Libros_Estudiantes_Load(object sender, EventArgs e)
        {
            CargarLibros();
            CargarEstudiantes();
        }

        private void CargarEstudiantes()
        {
            dtgEstudiantes.DataSource = new Capa.Logica.Estudiante_Logica().SeleccionarTodos();
            Otros_Estudiantes = new Capa.Logica.Estudiante_Logica().SeleccionarTodos();
        }

        private void CargarLibros()
        {
            try
            {
                dtgLibros.DataSource = new Capa.Logica.Libro_Logica().SeleccionarTodos();
                Otros_Libros = new Capa.Logica.Libro_Logica().SeleccionarTodos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
            Libros lib = dtgLibros.SelectedRows[0].DataBoundItem as Libros;
            Buscar(lib);

            Refrescar_Lista_Libros();
        }

        private void Refrescar_Lista_Libros()
        {
            try
            {
                lstLibrosPrestamo.DataSource = new List<Libros>();
                lstLibrosPrestamo.DataSource = Lista_Libros;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Buscar(Libros lib)
        {
            bool encontrado = false;
            if (lstLibrosPrestamo.DataSource ==null)
            {
                Lista_Libros.Add(lib);
                return;
                    
            }

            foreach (Libros libro in lstLibrosPrestamo.Items)
            {
                if (lib.Id == libro.Id)
                {
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Lista_Libros.Add(lib);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Lista_Libros.Remove(lstLibrosPrestamo.SelectedItem as Libros);
            Refrescar_Lista_Libros();
        }

        private void btnRalizarReporte_Click(object sender, EventArgs e)
        {
            if (Lista_Libros == null)
            {
                MessageBox.Show("Ingrese Libros para Generar el Reporte","Escuela Platanares",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            Reportes.frmRepLibros_QR ofrm = new frmRepLibros_QR();
            ofrm.Lista = Lista_Libros;
            ofrm.ShowDialog();
        }

        private void btnTodosIzquierda_Click(object sender, EventArgs e)
        {
            foreach (Libros libro in lstLibrosPrestamo.Items)
            {
                Lista_Libros.Remove(libro);
                Refrescar_Lista_Libros();
            }
        }

        private void btnTodosDerecha_Click(object sender, EventArgs e)
        {
            foreach (Libros item in Otros_Libros) 
            {
                Buscar(item);
                Refrescar_Lista_Libros();

            }
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {

            Estudiante estu = dtgEstudiantes.SelectedRows[0].DataBoundItem as Estudiante;
            Buscar_Estudiante(estu);

            Refrescar_Lista_Estudiante();
        }
        private void Buscar_Estudiante(Estudiante estu)
        {
            bool encontrado = false;
            if (lstEstudiantes.DataSource == null)
            {
                Lista_Estiduantes.Add(estu);
                return;

            }

            foreach (Estudiante estudiante in lstEstudiantes.Items)
            {
                if (estudiante.IdCedula == estu.IdCedula)
                {
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Lista_Estiduantes.Add(estu);
            }
        }

        private void btnAgregarEstudiantes_Click(object sender, EventArgs e)
        {
            foreach (Estudiante item in Otros_Estudiantes)
            {
                Buscar_Estudiante(item);
                Refrescar_Lista_Estudiante();

            }

        }
        private void Refrescar_Lista_Estudiante()
        {
            try
            {
                lstEstudiantes.DataSource = new List<Estudiante>();
                lstEstudiantes.DataSource = Lista_Estiduantes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            Lista_Estiduantes.Remove(lstEstudiantes.SelectedItem as Estudiante);
            Refrescar_Lista_Estudiante();
        }

        private void btnEliminarEstudiantes_Click(object sender, EventArgs e)
        {
            foreach (Estudiante estudiante in lstEstudiantes.Items)
            {
                Lista_Estiduantes.Remove(estudiante);
                Refrescar_Lista_Estudiante();
            }
        }

        private void btnReporteEstudiantes_Click(object sender, EventArgs e)
        {
            Reportes.frmRep_Estudiantes_QR ofrm = new frmRep_Estudiantes_QR();
            ofrm.lista = Lista_Estiduantes;
            ofrm.Show();
        }
    }
}
