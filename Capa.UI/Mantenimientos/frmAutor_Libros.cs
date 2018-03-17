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
    public partial class frmLibros_Autores : Form
    {
        Libro_Logica Logica = null;
        public frmLibros_Autores()
        {
            InitializeComponent();
            Logica = new Libro_Logica();
        }

        private void frmLibros_Autores_Load(object sender, EventArgs e)
        {
            cmbLibros.DataSource = Logica.SeleccionarTodos();
            cmbLibros.DisplayMember = "titulo";
            cmbLibros.ValueMember = "id";
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            Libro_Autor_Logica Logica = new Libro_Autor_Logica();

          dtgLibros_Autores.DataSource = Logica.SeleccionarTodos(((Libros)cmbLibros.SelectedItem).Id);
        }
    }
}
