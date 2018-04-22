using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
   public class Usuario
    {
        public int id { get; set; }
        public string Contrasenna { get; set; }
        public Roll Rol { get; set; }

        public override string ToString()
        {
            return id.ToString();
        }
    }
}

