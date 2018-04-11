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
        private int childFormNumber = 0;
        public Usuario Usuario { get; set; }
        public frmMenu_Admin()
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
            saveFileDialog.Filter = "Archivos de texto (*.pdf)|*.txt|Todos los archivos (*.*)|*.*";
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

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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
    }
}
