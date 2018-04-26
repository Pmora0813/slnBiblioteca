using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class Conexion
    {
        /// <summary>
        ///Clase con un metodi}o estatico
        ///para crear la conexcion de la BD
        /// </summary>
        public static string Cadena
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            }
        }
    }
}
