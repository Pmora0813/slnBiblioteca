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
    public partial class frmBuscar_Estudiante : Form
    {

        Estudiante_Logica Logica = null;
        public Estudiante estudiante { get; set; }
        public frmBuscar_Estudiante()
        {
            InitializeComponent();
            Logica = new Estudiante_Logica();
        }

        private void chkCedula_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCedula.Checked)
            {
                mskCedula.Visible = true;
            }
            else
            {
                mskCedula.Visible = false;
                mskCedula.Text = "";
            }
        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNombre.Checked)
            {
                mskNombre.Visible = true;
            }
            else
            {
                mskNombre.Visible = false;
                mskNombre.Text = "";
            }
        }

        private void chkSeccion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeccion.Checked)
            {
                txtSeccion.Visible = true;
            }
            else
            {
                txtSeccion.Visible = false;
                txtSeccion.Text = "";
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgEstudiantes.Refresh();

            int cedula = -1;
            string nombre = "";
            string seccion = "";

            if (chkCedula.Checked)
            {
                cedula = Convert.ToInt32(mskCedula.Text.Trim());

                if (mskCedula.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Ingrese la Cedula del Estudiante", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (chkNombre.Checked)
            {
                nombre = mskNombre.Text.Trim();

                if (mskNombre.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese el Nombre del Estudiante", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            


            if (chkSeccion.Checked)
            {

                seccion = txtSeccion.Text.Trim();
                if (txtSeccion.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese la Sección del Estudiante", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            dtgEstudiantes.DataSource = Logica.SeleccionarTodosFiltro(cedula, nombre, seccion);
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dtgEstudiantes.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Seleccione un Estudiante", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                estudiante = dtgEstudiantes.SelectedRows[0].DataBoundItem as Estudiante;
                this.Close();
            }
        }

        private void dtgEstudiantes_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgEstudiantes.DataSource != null)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
