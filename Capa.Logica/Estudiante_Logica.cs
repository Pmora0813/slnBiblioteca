using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Capa.Logica
{
    /// <summary>
    /// Clase encargada de hacer el 
    /// CRUD en la BD del Objeto ESTUDIANTE
    /// </summary>
    public class Estudiante_Logica
    {
        public void guardar(Estudiante estudiante)
        {
            if (String.IsNullOrWhiteSpace(estudiante.Nombre))
            {
                throw new ApplicationException("El nombre es requerido");
            }
            Datos.Estudiante_Datos datos = new Datos.Estudiante_Datos();
            if (datos.SeleccionarPorID(estudiante.IdCedula) == null)
                datos.Insertar(estudiante);
            else
                datos.Actualizar(estudiante);
        }

        public List<Estudiante> SeleccionarTodos()
        {
            Datos.Estudiante_Datos datos = new Datos.Estudiante_Datos();
            return datos.SeleccionarTodos();
        }
        public Estudiante SeleccionarEstudiantePorId(int Id)
        {
            Datos.Estudiante_Datos datos = new Datos.Estudiante_Datos();
            return datos.SeleccionarPorID(Id);
        }

        public void Eliminar(int Id)
        {
            Datos.Estudiante_Datos datos = new Datos.Estudiante_Datos();
            datos.Eliminar(Id);
        }

        public int edad(Estudiante est)
        {
            int edad = 0;
            DateTime t;
            try
            {
                var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
                if(myHttpWebRequest.Credentials== null)
                {
                    t = DateTime.Now;
                }
                else
                {

                    var response = myHttpWebRequest.GetResponse();
                    string[] dt = response.Headers.GetValues("Date");
                    t = Convert.ToDateTime(dt[0]);
                }
                

               

                edad =(int) t.Year - est.F_Nacimiento.Year;

                if (est.F_Nacimiento.Month > t.Month)
                {
                    if (est.F_Nacimiento.Day < t.Day)
                    {

                        edad -= 1;
                    }
                    
                }

            }
            catch (Exception)
            {

                throw;
            }


            return edad;

        }


        public List<Estudiante> SeleccionarTodosFiltro(int cedula, string nombre,string seccion)
        {
            Datos.Estudiante_Datos datos = new Datos.Estudiante_Datos();
            return datos.SeleccionarTodosFiltro(cedula, nombre,seccion);
        }

        public bool ComprobarFormatoEmail(string correo)
        {

            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, sFormato))
            {
                if (Regex.Replace(correo, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
