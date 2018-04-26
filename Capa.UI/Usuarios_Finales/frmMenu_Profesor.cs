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
    public partial class frmMenu_Profesor : Form
    {
        public Usuario usuario { get; set; }

        public frmMenu_Profesor()
        {
            InitializeComponent();
        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            Usuarios_Finales.frmPrestamo frm = new frmPrestamo();            
            frm.MdiParent = this;
            frm.Usuario = usuario;
            frm.Show();


        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            Menu_Profesor.frmDevoluciones ofrm = new Menu_Profesor.frmDevoluciones();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Usuarios_Finales.Menu_Profesor.frmSolicitudes_Prestamo ofrm = new Menu_Profesor.frmSolicitudes_Prestamo();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMenu_Profesor_Load(object sender, EventArgs e)
        {

        }

        private void frmMenu_Profesor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
                Owner.Show();
        }
    }
}
