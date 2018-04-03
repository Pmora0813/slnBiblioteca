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
            }
        }

        private void chkedad_CheckedChanged(object sender, EventArgs e)
        {

            if (chkedad.Checked)
            {
                mskedad.Visible = true;
            }
            else
            {
                mskedad.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cedula = 0;
            string nombre = "";
            int edad = 0;
            string seccion = "";
            List<Estudiante> lista_est = new List<Estudiante>();
            if (chkCedula.Checked)
            {
                cedula = Convert.ToInt32(mskCedula.Text);
                if (mskCedula.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese la Cedula del Estudiante", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (chkNombre.Checked)
            {
                nombre = mskNombre.Text;

                if (mskNombre.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese el Nombre del Estudiante", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (chkedad.Checked)
            {
                edad = Convert.ToInt32(mskedad.Text);
                if (mskedad.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese la Edad del Estudiante", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (chkSeccion.Checked)
            {

                seccion = txtSeccion.Text;
                if (txtSeccion.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese la Sección del Estudiante", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            try
            {

                List<Estudiante> lista = new Estudiante_Logica().SeleccionarTodos();

                foreach (var item in lista)
                {

                   // Estudiante estudiante = null;
                    if (item.IdCedula == cedula)
                    {
                        estudiante = item;
                    }
                    if (item.Nombre.Equals(nombre))
                    {
                        estudiante = item;
                    }
                    if (Logica.edad(item) == edad && edad > 0)
                    {
                        estudiante = item;
                    }
                    if (item.Seccion.Equals(seccion))
                    {
                        estudiante = item;
                    }

                    if (estudiante != null)
                    {
                        lista_est.Add(estudiante);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

            dtgEstudiantes.DataSource = lista_est;
        }

        private void frmBusquedaAvanzada_Load(object sender, EventArgs e)
        {

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
                this.Close();
            }
        }

        private void dtgEstudiantes_SelectionChanged(object sender, EventArgs e)
        {
            if(dtgEstudiantes.DataSource != null)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }
    }
}
