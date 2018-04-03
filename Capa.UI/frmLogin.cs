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

namespace Capa.UI
{
    public partial class frmLogin : Form
    {
        public Usuario Usuario { get; set; }
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
                    this.Usuario = item;
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
            if (mskUsuario.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Usuario", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (mskContrasenna.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Contraseña", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch (validarUsuario())
            {
                case 1:

                    Limpiar();
                    MessageBox.Show("Inicio de Seccion modo Administrador", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Usuarios_Finales.frmP_Menu_Admin ofrm = new Usuarios_Finales.frmP_Menu_Admin();
                    ofrm.Usuario = this.Usuario;
                    ofrm.ShowDialog();
                    break;
                case 2:
                    Limpiar();

                    MessageBox.Show("Inicio de Seccion modo Profesor", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("Inicio de Seccion modo Estudiante", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    Limpiar();
                    MessageBox.Show("Usuario Incorecto", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }

        private void Limpiar()
        {
            mskUsuario.Text = " ";
            mskContrasenna.Text = " ";
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            //frmLogin ofrm2 = new frmLogin();
            //Usuarios_Finales.frmRegistro ofrm = new Usuarios_Finales.frmRegistro();
            //ofrm2.MinimizeBox = true;
            //ofrm.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Usuarios_Finales.frmP_Menu_Admin ofrm = new Usuarios_Finales.frmP_Menu_Admin();
            //ofrm.Usuario = this.Usuario;
            //ofrm.Show();

        }
    }
}
