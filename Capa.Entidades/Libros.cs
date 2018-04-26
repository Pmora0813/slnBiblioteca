using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.Entidades
{
    /// <summary>
    /// Endidad Libros
    /// Con todos sus atributos
    /// </summary>
    public class Libros
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int anno { get; set; }
        public Editorial Editorial { get; set; }
        public List<Autor> Lista { get; set; }
        public Byte[] Codigo { get; set; }
        /// <summary>
        /// Sobreescribimos el metodo ToString
        /// Para que no muestre la Descripción
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return "Codigo: " + Id + "\r\n   Titulo: " + Titulo;
        }
    }
}
