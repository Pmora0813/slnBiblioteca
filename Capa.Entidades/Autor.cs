﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    /// <summary>
    /// Clase Autor
    /// </summary>
    public class Autor
    {
        /// <summary>
        /// Tiene 2 propiedades 
        /// El id y el Nombre
        /// </summary>
        public int Id { get; set; }
        public string Nombre { get; set; }

        /// <summary>
        /// Sobreescribimos en metodo
        /// ToString para que nos muestre el nombre
        /// del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nombre;
        }
    }
}
