using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class Prestamo_Logica
    {
        public void guardar(Prestamo prestamo)
        {
            if (String.IsNullOrWhiteSpace(prestamo.id.ToString()))
            {
                throw new ApplicationException("El Codigo es requerido");
            }
            Datos.Prestamo_Datos datos = new Datos.Prestamo_Datos();
            if (datos.SeleccionarPorID(prestamo.id) == null)
                datos.Insertar(prestamo);
            else
                datos.Actualizar(prestamo);
        }

        public List<Prestamo> SeleccionarTodos()
        {
            Datos.Prestamo_Datos datos = new Datos.Prestamo_Datos();
            return datos.SeleccionarTodos();
        }
        public Prestamo SeleccionarPrestamoPorId(int Id)
        {
            Datos.Prestamo_Datos datos = new Datos.Prestamo_Datos();
            return datos.SeleccionarPorID(Id);
        }

        public void Eliminar(int Id)
        {
            Datos.Prestamo_Datos datos = new Datos.Prestamo_Datos();
            datos.Eliminar(Id);
        }
        public DateTime ObtenerFecha()
        {
            try
            {
                var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
                var response = myHttpWebRequest.GetResponse();

                string[] dt = response.Headers.GetValues("Date");
                DateTime t = Convert.ToDateTime(dt[0]);

                if (t == null)
                {
                    t = DateTime.Now;
                }
                return t;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}