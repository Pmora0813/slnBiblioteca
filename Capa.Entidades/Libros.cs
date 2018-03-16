using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Libros
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Qr { get; set; }
        public Editorial Editorial { get; set; }
        public List<Autor> Lista { get; set; }
        
    }
}
