using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Prestamo
    {
        public int id { get; set; }
        public DateTime Fecha_Act { get; set; }
        public DateTime Fecha_Dev { get; set; }
        public int minutos { get; set; }
        public int horas { get; set; }
        public int dias { get; set; }
        public Estudiante estudiant { get; set; }
        //public Libros Libro { get; set; }
        public Usuario Usuario { get; set; }
        public Categoria Categoria { get; set; }
    }
}
