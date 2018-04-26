using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Reportes
{
    public partial class frmRepLibros_Mas_Prestados : Form
    {
        public frmRepLibros_Mas_Prestados()
        {
            InitializeComponent();
        }

        private void frmRepLibros_Mas_Prestados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet2.TOP_5_LIBROS_MAS_PRESTADOS' Puede moverla o quitarla según sea necesario.
            this.tOP_5_LIBROS_MAS_PRESTADOSTableAdapter.Fill(this.bibliotecaDataSet2.TOP_5_LIBROS_MAS_PRESTADOS);

            this.reportViewer1.RefreshReport();
        }
    }
}
