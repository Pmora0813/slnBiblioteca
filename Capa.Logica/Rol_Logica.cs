using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class Rol_Logica
    {
        public List<Roll> SeleccionarTodos()
        {
            Datos.Rol_Datos datos = new Datos.Rol_Datos();
            return datos.SeleccionarRoles();
        }
    }
}
