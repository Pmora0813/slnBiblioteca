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

namespace Capa.UI.Usuarios_Finales.Menu_Profesor
{
    public partial class frmDevoluciones : Form
    {
        Prestamo_Logica Logica = null;
        List<Libros> Lista_Libros = null;
        Libros libro = null;
        Prestamo prestamo = null;
        public frmDevoluciones()
        {
            InitializeComponent();
            Logica = new Prestamo_Logica();
            Lista_Libros = new List<Libros>();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskCodigoprestamo.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese el Codigo del Prestamo.", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }
                prestamo = Logica.SeleccionarPrestamoPorId(Convert.ToInt32(mskCodigoprestamo.Text.Trim()));

                if (prestamo == null)
                {
                    MessageBox.Show("Prestamo NO encontrado.", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Validador_de_Solicitud(prestamo))
                {
                    return;
                }
                List<Libros> L_Prestados = new Capa.Logica.Prestamo_Libros_Logica().SeleccionarTodos(Convert.ToInt32(mskCodigoprestamo.Text.Trim()));
                lstLibrosPrestamo.DataSource = L_Prestados;
            }
            catch (Exception)
            {

                throw;
            }
            MostrarLogo();
            if (lstLibrosPrestamo.Items.Count > 0)
            {
                btnBuscarLibro.Enabled = true;
                btnAgregarLibro.Enabled = true;
            }

        }

        private bool Validador_de_Solicitud(Prestamo prestamo)
        {
            bool estado = false;
            if (prestamo.Categoria.Id == 2)
            {
                MessageBox.Show("El prestamo Numero: " + prestamo.id + " ya fue procesado como Devolucion.", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado = true;
            }
            if (prestamo.Categoria.Id == 1 || prestamo.Categoria.Id == 3)
            {
                MessageBox.Show("El prestamo Numero: " + prestamo.id + " \nNo tiene una Solicitud de Devolucion.", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado = true;
            }
            return estado;
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskCodigoLibro.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese el Codigo del Libro.", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }

                libro = new Capa.Logica.Libro_Logica().SeleccionarPorID(Convert.ToInt32(mskCodigoLibro.Text.Trim()));
                if (libro != null)
                {
                    txtTitulo.Text = libro.Titulo;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Refrescar()
        {
            lstLibros.DataSource = null;
            lstLibros.DataSource = Lista_Libros;
            lstLibros.Refresh();

            MostrarLogo();

        }

        private void MostrarLogo()
        {

            bool Aceptar_Devolucion = false;


            foreach (Libros LP in lstLibrosPrestamo.Items)
            {
                foreach (Libros LB in lstLibros.Items)
                {
                    if (LP.Id == LB.Id)
                    {
                        Aceptar_Devolucion = true;
                    }
                    else
                    {
                        Aceptar_Devolucion = false;
                    }

                }
            }

            if (Aceptar_Devolucion)
            {
                btnAceptar.Visible = true;
                pnlFaltaLibro.Visible = false;

            }
            else
            {
                pnlFaltaLibro.Visible = true;
                btnAceptar.Visible = false;
            }


        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            try
            {
                if (mskCodigoLibro.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese el Codigo del Libro.", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }
                if (lstLibros.DataSource == null)
                {
                    Lista_Libros.Add(libro);
                }
                else
                {
                    foreach (Libros lib in Lista_Libros)
                    {
                        if (lib.Id == libro.Id)
                        {
                            encontrado = true;
                        }
                    }

                    if (!encontrado)
                    {
                        Lista_Libros.Add(libro);

                        Refrescar();

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            Refrescar();
        }

        private void pnlFaltaLibro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstLibros_DoubleClick(object sender, EventArgs e)
        {
            MostrarLogo();
            try
            {
                Lista_Libros.Remove(lstLibros.SelectedItem as Libros);

                Refrescar();
                if (lstLibros.Items.Count == 0 && lstLibrosPrestamo.Items.Count == 0)
                {
                    btnAceptar.Visible = false;
                    pnlFaltaLibro.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mskCodigoprestamo_TextChanged(object sender, EventArgs e)
        {
            if (mskCodigoprestamo.Text.Equals(""))
            {
                lstLibrosPrestamo.DataSource = null;
                btnAceptar.Visible = false;
                pnlFaltaLibro.Visible = true;
                lstLibrosPrestamo.Refresh();
                Lista_Libros = new List<Libros>();
                limpiar();
            }
            if (lstLibrosPrestamo.Items.Count == 0 && lstLibros.Items.Count == 0)
            {
                btnAceptar.Visible = false;
                pnlFaltaLibro.Visible = false;
                btnBuscarLibro.Enabled = false;
                btnAgregarLibro.Enabled = false;
            }


        }

        private void mskCodigoLibro_TextChanged(object sender, EventArgs e)
        {
            if (mskCodigoLibro.Text.Equals(""))
            {
                txtTitulo.Text = "";
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (prestamo != null)
                {
                    prestamo.Categoria = new Capa.Logica.Categoira_Logica().SeleccionarCategoriaPorId(2);
                    Logica.guardar(prestamo);
                    limpiar();
                    MessageBox.Show("Devolucion Realizada con Exito.", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void limpiar()
        {
            try
            {
                mskCodigoLibro.Text = "";
                mskCodigoprestamo.Text = "";
                txtTitulo.Text = "";
                lstLibros.DataSource = null;
                lstLibrosPrestamo.DataSource = null;
                btnAceptar.Visible = false;
                pnlFaltaLibro.Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmDevoluciones_Load(object sender, EventArgs e)
        {
            try
            {
                dtgSolicitudes_Devol.DataSource = Logica.Solicitudes_Devol();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
