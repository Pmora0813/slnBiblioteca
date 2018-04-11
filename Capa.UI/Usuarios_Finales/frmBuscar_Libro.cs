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
    public partial class frmBuscar_Libro : Form
    {
        public Libros Libro { get; set; }
        Libro_Logica Logica = null;
        public frmBuscar_Libro()
        {
            InitializeComponent();
            Logica = new Libro_Logica();
        }

        private void frmBuscar_Libro_Load(object sender, EventArgs e)
        {
            try
            {
                cmbEditorial.DataSource = new Editorial_Logica().SeleccionarTodosFiltro();
                cmbEditorial.DisplayMember = "Nombre";
                cmbEditorial.ValueMember = "id";
                cmbEditorial.SelectedIndex = -1;


                cmbAutor.DataSource = new Autor_Logica().SeleccionarTodosFiltro();
                cmbAutor.DisplayMember = "Nombre";
                cmbAutor.ValueMember = "id";
                cmbAutor.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void chkTitulo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTitulo.Checked)
            {
                txtTiluto.Visible = true;
            }
            else
            {
                txtTiluto.Visible = false;
                txtTiluto.Text = "";
            }
        }

        private void chkAutor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutor.Checked)
            {
                cmbAutor.Visible = true;
            }
            else
            {
                cmbAutor.Visible = false;
                cmbAutor.SelectedIndex = -1;
            }

        }

        private void chkEditorial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditorial.Checked)
            {
                cmbEditorial.Visible = true;
            }
            else
            {
                cmbEditorial.Visible = false;
                cmbEditorial.SelectedIndex = -1;
            }
        }

        private void chkAnno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnno.Checked)
            {
                mskAnno.Visible = true;
            }
            else
            {
                mskAnno.Visible = false;
                mskAnno.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dtgLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgLibros.DataSource != null)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgLibros.Refresh();

            int id = -1;
            string titulo = "";
            int anno = -1;
            int idAutor = -1;
            int idEditorial = -1;

            if (chkTitulo.Checked)
            {
                if (txtTiluto.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Ingrese el Titulo del Libro", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                titulo = txtTiluto.Text.Trim();
            }

            if (chkAnno.Checked)
            {
                if (mskAnno.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese el Año del Libro", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                anno = Convert.ToInt32(mskAnno.Text.Trim());
            }



            if (chkEditorial.Checked)
            {
                if (cmbEditorial.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione la Editorial del Libro", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                idEditorial = ((Editorial)cmbEditorial.SelectedItem).Id;
            }

            if (chkAutor.Checked)
            {
                if (cmbAutor.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione el Autor del Libro", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                idAutor = ((Autor)cmbAutor.SelectedItem).Id;
            }

            dtgLibros.DataSource = Logica.SeleccionarTodosFiltro(id, titulo, idAutor, idEditorial, anno);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (dtgLibros.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Seleccione un Libro", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Libro = dtgLibros.SelectedRows[0].DataBoundItem as Libros;
                this.Close();
            }
        }
    }
}