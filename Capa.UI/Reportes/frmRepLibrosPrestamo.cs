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
    public partial class frmRepLibrosPrestamo : Form
    {
        public frmRepLibrosPrestamo()
        {
            InitializeComponent();
        }

        private void frmRepLibrosPrestamo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.REP_LIBROS_PRESTAMO' Puede moverla o quitarla según sea necesario.
            this.rEP_LIBROS_PRESTAMOTableAdapter.Fill(this.bibliotecaDataSet.REP_LIBROS_PRESTAMO);

            this.reportViewer1.RefreshReport();
        }
    }
}
