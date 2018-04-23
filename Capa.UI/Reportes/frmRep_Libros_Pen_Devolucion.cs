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
    public partial class frmRep_Libros_Pen_Devolucion : Form
    {
        public frmRep_Libros_Pen_Devolucion()
        {
            InitializeComponent();
        }

        private void frmRep_Libros_Pen_Devolucion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet1.REP_LIBROS_PENDIENTES_DEV' Puede moverla o quitarla según sea necesario.
            this.rEP_LIBROS_PENDIENTES_DEVTableAdapter.Fill(this.bibliotecaDataSet1.REP_LIBROS_PENDIENTES_DEV);

            this.reportViewer1.RefreshReport();
        }
    }
}
