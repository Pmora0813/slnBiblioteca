using Capa.Entidades;
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
    public partial class frmP_Menu_Admin : Form
    {
        private int childFormNumber = 0;
        public Usuario Usuario { get; set; }

        public frmP_Menu_Admin()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmMant_Usuario ofrm = new Mantenimientos.frmMant_Usuario();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void frmP_Menu_Admin_Load(object sender, EventArgs e)
        {
            //lblUsuario.Text =Usuario.id+" "+ Usuario.Rol.descripcion;
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmMant_Autor ofrm = new Mantenimientos.frmMant_Autor();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmMant_Editorial ofrm = new Mantenimientos.frmMant_Editorial();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void estudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmMant_Estudiante ofrm = new Mantenimientos.frmMant_Estudiante();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmMant_Libros ofrm = new Mantenimientos.frmMant_Libros();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void agrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmLibros_Autores ofrm = new Mantenimientos.frmLibros_Autores();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmMant_Categorias ofrm = new Mantenimientos.frmMant_Categorias();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrestamo ofrm = new frmPrestamo();
            ofrm.Usuario = Usuario;
            ofrm.MdiParent = this;
           
            ofrm.Show();
        }

        private void cerrarSeciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
