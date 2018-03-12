﻿using System;
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
        public int Cant_Disponibles { get; set; }
        public string Qr { get; set; }
        public int IdEditorial { get; set; }
        public List<Autor> Autor { get; set; }
        
    }
}