﻿using Capa.Entidades;
using Capa.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI
{
    public partial class frmLogin : Form
    {
        public Usuario Usuario { get; set; }
        public Estudiante Estudiante { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           // EnviarNotificacionesDevoluciones();
        }

        private void EnviarNotificacionesDevoluciones()
        {
            try
            {

                DateTime Actual = new Capa.Logica.Prestamo_Logica().ObtenerFecha();
                List<Prestamo> Lista = new Capa.Logica.Prestamo_Logica().SeleccionarTodos();
                foreach (Prestamo item in Lista)
                {
                    if (item.dias <= Actual.Day)
                    {
                        if (item.horas <= Actual.Hour)
                        {
                            if (item.minutos < Actual.Minute)
                            {
                                enviar_correo(item);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void enviar_correo(Prestamo prestamo)
        {
            string host = "smtp-mail.outlook.com";
            int puerto = 587;
            string remitente = "pmora0813@hotmail.com";
            string contraseña = "Pabl0m0ra0813";
            string destinatarios = prestamo.estudiant.Email;
            string nombre = "Escuela Platanares";
            string cuerpo = "Estimado estudiante " + prestamo.estudiant.Nombre + "." +
                           "Recuerde la devolucion de los libros que " +
                           "se encuentra registrados a su nombre en el " +
                            "pretamo #" + prestamo.id;
            try
            {

                SmtpClient cliente = new SmtpClient(host, puerto);
                MailMessage correo = new MailMessage();

                correo.To.Add(destinatarios);
                correo.From = new MailAddress(remitente, nombre);
                correo.Body = cuerpo;

                cliente.Credentials = new NetworkCredential(remitente, contraseña);
                cliente.EnableSsl = true;
                cliente.Send(correo);
                
            }
            catch (Exception)
            {
                throw;
                
            }
            Cursor = Cursors.Arrow;
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
                    Estudiante = item;
                }
            }

            return Roll;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int roll = validarUsuario();
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

            switch (roll)
            {
                case 1:
                    Limpiar();
                    Usuarios_Finales.frmMenu_Admin ofrm = new Usuarios_Finales.frmMenu_Admin();
                    ofrm.Owner = this;
                    ofrm.Usuario = this.Usuario;
                    ofrm.Show();
                    this.Hide();
                    break;
                case 2:
                    Limpiar();
                    Usuarios_Finales.frmMenu_Profesor frmProf = new Usuarios_Finales.frmMenu_Profesor();
                    frmProf.Owner = this;
                    frmProf.usuario = this.Usuario;
                    frmProf.Show();
                    this.Hide();
                    break;
                case 3:
                    Limpiar();
                   this.Usuario = new Usuario()
                    {
                        id = 100000000,
                        Contrasenna = "123456",
                        Rol = new Capa.Logica.Rol_Logica().SeleccionarRollPorId(3)
                    };
                    Menu_Estudiante.frmPrestamo_Estudiente ofrmEstudiante = new Menu_Estudiante.frmPrestamo_Estudiente();
                    ofrmEstudiante.Usuario = Usuario;
                    ofrmEstudiante.Show();
                    break;
                default:
                    Limpiar();
                    MessageBox.Show("Credenciales Incorectas", "Escuela Platanares", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Limpiar();
            Usuarios_Finales.frmRegistro ofrm = new Usuarios_Finales.frmRegistro();
            ofrm.Owner = this;
            this.Hide();
            ofrm.ShowDialog();



        }
    }
}
