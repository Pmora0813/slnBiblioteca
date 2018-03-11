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
    public partial class frmMant_Categorias : Form
    {
        private string escuela = "Escuela Platanares";
        private Categoira_Logica Logica;
        public frmMant_Categorias()
        {
            InitializeComponent();
            Logica = new Categoira_Logica();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria aut = new Categoria()
                {
                    Id = int.Parse(npdID.Text),
                    Descripcion = txtCateg.Text
                };
                Logica.guardar(aut);
                Refrescar();
                MessageBox.Show("Categoria guardada con Exito", escuela, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Refrescar()
        {
            dtgCategorias.DataSource = Logica.SeleccionarTodos();
        }

        private void frmMant_Categorias_Load(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (npdID.Value <= 0)
            {
                MessageBox.Show("No hay Categorias para Eliminar", escuela, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            try
            {
                DialogResult resultado = MessageBox.Show("Esta Seguro?", escuela, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Logica.Eliminar(Convert.ToInt32(npdID.Text));
                    MessageBox.Show("Categoira eliminada con Exito", escuela, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Refrescar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgCategorias.SelectedRows.Count > 0)
            {
                Categoria cat = (Categoria)dtgCategorias.SelectedRows[0].DataBoundItem;
                npdID.Text = cat.Id.ToString();
                txtCateg.Text = cat.Descripcion;
            }
        }
    }
}
