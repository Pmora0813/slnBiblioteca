using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Estudiante
    {
        public int IdCedula { get; set; }
        public string Contrasenna { get; set; }
        public string Nombre { get; set; }
        public string Seccion { get; set; }
        public string Genero { get; set; }
        public DateTime F_Nacimiento { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public bool Activo { get; set; }
        public string QR { get; set; }
        public Roll Roll { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
