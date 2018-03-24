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
    public partial class frmBuscarAutores : Form
    {
        Autor_Logica Logica = null;

        public Entidades.Autor Autor { get; set; }
        public frmBuscarAutores()
        {
            InitializeComponent();
            Logica = new Autor_Logica();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (lstAutores.SelectedItem != null)
            {
                this.Autor = (Autor)lstAutores.SelectedItem;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Autor");
            }
               
        }

        private void frmBuscarAutores_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            try
            {
                lstAutores.DataSource = Logica.SeleccionarTodos();
                lstAutores.DisplayMember = "Nombre";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
