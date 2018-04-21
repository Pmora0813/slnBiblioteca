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

namespace Capa.UI.Usuarios_Finales.Menu_Profesor
{
    public partial class frmDevoluciones : Form
    {
        List<Libros> Lista_Libros = null;
        Libros libro = null;
        public frmDevoluciones()
        {
            InitializeComponent();

            Lista_Libros = new List<Libros>();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Libros> L_Prestados = new Capa.Logica.Prestamo_Libros_Logica().SeleccionarTodos(Convert.ToInt32(mskCodigoprestamo.Text.Trim()));

                lstLibrosPrestamo.DataSource = L_Prestados;
            }
            catch (Exception)
            {

                throw;
            }
            MostrarLogo();

        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {

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
                if (lstLibros.Items.Count == 0 && lstLibrosPrestamo.Items.Count ==0)
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
            }
            if (lstLibrosPrestamo.Items.Count == 0 && lstLibros.Items.Count==0)
            {
                btnAceptar.Visible = false;
                pnlFaltaLibro.Visible = false;
            }
        }

        private void mskCodigoLibro_TextChanged(object sender, EventArgs e)
        {
            if (mskCodigoLibro.Text.Equals(""))
            {
                txtTitulo.Text = "";
            }

        }
    }
}
