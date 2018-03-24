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

namespace Capa.UI.Mantenimientos
{
    public partial class frmMant_Autor : Form
    {
        private string escuela = "Escuela Platanares";
        Autor_Logica Logica = null;
        public frmMant_Autor()
        {
            InitializeComponent();
            Logica = new Autor_Logica();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Autor aut = new Autor()
                {
                    Id = int.Parse(npdID.Text),
                    Nombre = txtNombre.Text
                };
                Logica.guardar(aut);
                Refrescar();
                MessageBox.Show("Autor guardado con Exito", escuela, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmMant_Autor_Load(object sender, EventArgs e)
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
            dtgAutores.DataSource = Logica.SeleccionarTodos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Logica.Eliminar(Convert.ToInt32(npdID.Text));

                MessageBox.Show("Autor Eliminado con Exito", escuela, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgAutores_SelectionChanged(object sender, EventArgs e)
        {

            if (dtgAutores.SelectedRows.Count > 0)
            {
                Autor aut = (Autor)dtgAutores.SelectedRows[0].DataBoundItem;
                npdID.Text = aut.Id.ToString();
                txtNombre.Text = aut.Nombre;
            }
        }
    }
}
