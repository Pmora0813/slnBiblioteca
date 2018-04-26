using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    /// <summary>
    /// La Clase Categoria tiene
    /// una Identificación y una 
    /// descripcion
    /// </summary>
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        /// <summary>
        /// Sobreescribimos el metodo ToString
        /// Para que no muestre la Descripción
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
