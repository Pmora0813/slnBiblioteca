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
    public partial class frmMant_Editorial : Form
    {
        string escuela = "Escuela Platanares";
        Editorial_Logica Logica = null;
        public frmMant_Editorial()
        {
            InitializeComponent();
            Logica = new Editorial_Logica();
        }

        private void frmMant_Editorial_Load(object sender, EventArgs e)
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
            dtgEditoriales.DataSource = Logica.SeleccionarTodos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editorial edit = new Editorial()
                {
                    Id = int.Parse(npdCodigo.Text),
                    Nombre = txtNombre.Text
                };
                Logica.guardar(edit);
                Refrescar();
                MessageBox.Show("Editorial guardada con Exito", escuela, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (npdCodigo.Value <= 0)
            {
                MessageBox.Show("No hay Editoriales para Eliminar", escuela, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            try
            {
                DialogResult resultado = MessageBox.Show("Esta Seguro?", escuela, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Logica.Eliminar(Convert.ToInt32(npdCodigo.Text));
                    MessageBox.Show("Editorial eliminada con Exito", escuela, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Refrescar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgEditoriales_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgEditoriales.SelectedRows.Count > 0)
            {
                Editorial aut = (Editorial)dtgEditoriales.SelectedRows[0].DataBoundItem;
                npdCodigo.Text = aut.Id.ToString();
                txtNombre.Text = aut.Nombre;
            }
        }
    }
}
