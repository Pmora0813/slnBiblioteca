using Capa.Entidades;
using Capa.UI.Mantenimientos;
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
    public partial class frmMenu_Admin : Form
    {
        public Usuario Usuario { get; set; }
        public frmMenu_Admin()
        {
            InitializeComponent();
        }       


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMant_Usuario ofrm = new frmMant_Usuario();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMant_Estudiante ofrm = new frmMant_Estudiante();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMant_Libros ofrm = new frmMant_Libros();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMant_Autor ofrm = new frmMant_Autor();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMant_Editorial ofrm = new frmMant_Editorial();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void tipoDeSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMant_Categorias ofrm = new frmMant_Categorias();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void agregarAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibros_Autores ofrm = new frmLibros_Autores();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void frmMenu_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
                Owner.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios_Finales.frmPrestamo ofrm = new frmPrestamo();
            ofrm.MdiParent = this;
            ofrm.Usuario = Usuario;
            ofrm.Show();

            
        }

        private void frmMenu_Admin_Load(object sender, EventArgs e)
        {

        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {

        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.frmRepLibrosPrestamo ofrm = new Reportes.frmRepLibrosPrestamo();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void librosPendientesDevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmRep_Libros_Pen_Devolucion ofrm = new Reportes.frmRep_Libros_Pen_Devolucion();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void librosYEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmRep_Libros_Estudiantes ofrm = new Reportes.frmRep_Libros_Estudiantes();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void librosMasPrestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmRepLibros_Mas_Prestados ofrm = new Reportes.frmRepLibros_Mas_Prestados();
            ofrm.MdiParent = this;
            ofrm.Show();
        }
    }
}
