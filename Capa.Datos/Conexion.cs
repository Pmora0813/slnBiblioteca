using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class Conexion
    {
        public static string Cadena
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            }
        }
    }
}
