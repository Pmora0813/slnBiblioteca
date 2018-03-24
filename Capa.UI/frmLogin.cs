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

namespace Capa.UI
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private int validarUsuario()
        {
            int Roll = 0;
            List<Usuario> lista_Usuarios = new List<Usuario>();
            lista_Usuarios = new Logica.Usuario_Logica().SeleccionarTodos();

            foreach (Usuario item in lista_Usuarios)
            {
                string a = item.id.ToString();
                string b = item.Contrasenna.ToString();

                if (item.id.Equals(Convert.ToInt32(mskUsuario.Text.Trim())) && item.Contrasenna.Equals(mskContrasenna.Text.Trim()))
                {
                    Roll = Convert.ToInt32(item.Rol.id);
                }
            }

            List<Estudiante> lista_Estudiantes = new Logica.Estudiante_Logica().SeleccionarTodos();
            foreach (Estudiante item in lista_Estudiantes)
            {
                if (item.IdCedula.Equals(Convert.ToInt32(mskUsuario.Text.Trim())) && item.Contrasenna.Equals(mskContrasenna.Text.Trim()))
                {
                    Roll = Convert.ToInt32(item.Roll.id);
                }
            }

            return Roll;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            switch (validarUsuario())
            {
                case 1:
                    MessageBox.Show("Inicio de Seccion modo Administrador", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPrincipal ofrm = new frmPrincipal();
                    ofrm.ShowDialog();                    
                    break;
                case 2:

                    MessageBox.Show("Inicio de Seccion modo Profesor", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("Inicio de Seccion modo Estudiante", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    mskUsuario.Text = " ";
                    mskContrasenna.Text = " ";
                    MessageBox.Show("Usuario Incorecto", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Usuarios_Finales.frmRegistro ofrm = new Usuarios_Finales.frmRegistro();
            ofrm.Show();
        }
    }
}
