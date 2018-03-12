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
    public partial class frmMant_Usuario : Form
    {
        private string escuela = "Escuela Platanares";
        Usuario_Logica Logica = null;
        public frmMant_Usuario()
        {
            InitializeComponent();
            Logica = new Usuario_Logica();
        }

        private void frmMant_Usuario_Load(object sender, EventArgs e)
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
            dtgUsuarios.DataSource = Logica.SeleccionarTodos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Roll rol = (Roll)cmbRoles.SelectedItem;
                Usuario usua = new Usuario()
                {
                    id = int.Parse(mskUsuaro.Text),
                    Contrasenna = mskContrasenna.Text,
                    Roll = Convert.ToInt32(rol.id)
                };
                Logica.guardar(usua);
                Refrescar();
                MessageBox.Show("Usuario guardado con Exito", escuela, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (mskUsuaro.Text.Length <= 0)
            {
                MessageBox.Show("No hay Usuarios para Eliminar", escuela, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            try
            {
                DialogResult resultado = MessageBox.Show("Esta Seguro?", escuela, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Logica.Eliminar(Convert.ToInt32(mskUsuaro.Text));
                    MessageBox.Show("Usuario eliminado con Exito", escuela, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Refrescar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, escuela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgUsuarios.SelectedRows.Count > 0)
            {
                Usuario usu = (Usuario)dtgUsuarios.SelectedRows[0].DataBoundItem;
                mskUsuaro.Text = usu.id.ToString();
                mskContrasenna.Text = usu.Contrasenna;
            }
        }
    }
}
