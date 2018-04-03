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
        Libro_Logica Libro_Logica = null;
        Libro_Autor_Logica Logica_Lib_Aut = null;
        public frmLibros_Autores()
        {
            InitializeComponent();
            Libro_Logica = new Libro_Logica();
            Logica_Lib_Aut = new Libro_Autor_Logica();
        }

        private void frmLibros_Autores_Load(object sender, EventArgs e)
        {
            Refrescar();


        }

        private void Refrescar()
        {
            try
            {
                lstLibros.DisplayMember = "titulo";
                lstLibros.DataSource = Libro_Logica.SeleccionarTodos();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void lstLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLibros.SelectedItem != null)
            {
                lstLibros.DisplayMember = "Nombre";
                Libros libro = (Libros)lstLibros.SelectedItem;

                lstAutores.DataSource = Logica_Lib_Aut.SeleccionarTodos(libro.Id);

            }
        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Libros lib = (Libros)lstLibros.SelectedItem;
                Mantenimientos.frmBuscarAutores ofrm = new frmBuscarAutores();
                ofrm.ShowDialog();

                Autor aut = ofrm.Autor;

                if (lib != null && aut != null)
                {

                    Logica_Lib_Aut.guardar(lib, aut);

                    Refrescar();
                    MessageBox.Show("Se Agrego un Autor al Libro seleccionado", "Escuela Platanares",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAutores.SelectedItem == null)
                {
                    MessageBox.Show("No se encuentran Autores para eliminar", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Libros lib = (Libros)lstLibros.SelectedItem;
                Autor aut = (Autor)lstAutores.SelectedItem;

                if (lib != null && aut != null)
                {
                    
                    Logica_Lib_Aut.Eliminar(lib, aut);

                    Refrescar();
                    MessageBox.Show("Se elimino un Autor del Libro seleccionado","Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
