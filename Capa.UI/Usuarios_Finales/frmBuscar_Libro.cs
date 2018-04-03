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
        public frmBuscar_Libro()
        {
            InitializeComponent();
        }

        private void frmBuscar_Libro_Load(object sender, EventArgs e)
        {
            try
            {
                cmbEditorial.DataSource = new Editorial_Logica().SeleccionarTodos();
                cmbEditorial.SelectedIndex = -1;
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
            }
        }

        private void chkAutor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutor.Checked)
            {
                txtAutor.Visible = true;
            }
            else
            {
                txtAutor.Visible = false;
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
            }
        }
    }
}
