using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmMant_Autor ofrm = new Mantenimientos.frmMant_Autor();
            //ofrm.MdiParent = this;
            ofrm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmMant_Editorial ofrm = new Mantenimientos.frmMant_Editorial();
            ofrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmMant_Libros ofrm = new Mantenimientos.frmMant_Libros();
            ofrm.Show();
        }

        private void btnMant_Categorias_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmMant_Categorias ofrm = new Mantenimientos.frmMant_Categorias();
            ofrm.Show();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmMant_Estudiante ofrm = new Mantenimientos.frmMant_Estudiante();
            ofrm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmMant_Usuario ofrm = new Mantenimientos.frmMant_Usuario();
            ofrm.Show();
        }

        private void btnAutores_Libro_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmLibros_Autores ofrm = new Mantenimientos.frmLibros_Autores();
            ofrm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
