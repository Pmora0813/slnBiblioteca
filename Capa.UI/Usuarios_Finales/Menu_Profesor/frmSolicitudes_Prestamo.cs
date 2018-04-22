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
    public partial class frmSolicitudes_Prestamo : Form
    {
        Prestamo prestamo = null;
        Prestamo_Logica Logica = null;
        public frmSolicitudes_Prestamo()
        {
            InitializeComponent();
            Logica = new Prestamo_Logica();
        }

        private void frmSolicitudes_Devolucion_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            try
            {
                dtgSolicitudes_Prestamo.DataSource = new Capa.Logica.Prestamo_Logica().Solicitudes_Prestamo();
                if (txtCodigo.Text.Equals(""))
                {
                    txtCodigo.Text = "";
                    dtgLibros.DataSource = null;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dtgSolicitudes_Prestamo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgSolicitudes_Prestamo.SelectedRows.Count > 0)
                {
                    prestamo = dtgSolicitudes_Prestamo.SelectedRows[0].DataBoundItem as Prestamo;
                    if (prestamo != null)
                    {
                        txtCodigo.Text = prestamo.id.ToString();

                        dtgLibros.DataSource = new Logica.Prestamo_Libros_Logica().SeleccionarTodos(prestamo.id);

                    }

                }
                else
                {
                    txtCodigo.Text = "";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAceptarSolicitud_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals("") || prestamo == null)
            {
                MessageBox.Show("Seleccion un Prestamos", "Escuela Platanes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            prestamo.Categoria = new Capa.Logica.Categoira_Logica().SeleccionarCategoriaPorId(1);
            Logica.guardar(prestamo);
            MessageBox.Show("Se registro la Solicitud del Prestamos", "Escuela Platanes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refrescar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(""))
            {
                dtgLibros.Visible = false;
            }
            else
            {
                dtgLibros.Visible = true;
            }
        }
    }
}

