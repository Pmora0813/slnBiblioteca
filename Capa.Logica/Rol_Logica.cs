using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    /// <summary>
    /// Clase encargada de hacer el 
    /// CRUD en la BD del Objeto ROLL
    /// </summary>
    public class Rol_Logica
    {
        public List<Roll> SeleccionarTodos()
        {
            Datos.Rol_Datos datos = new Datos.Rol_Datos();
            return datos.SeleccionarRoles();
        }

        public Roll SeleccionarRollPorId(int Id)
        {
            Datos.Rol_Datos datos = new Datos.Rol_Datos();
            return datos.SeleccionarPorID(Id);
        }
    }
}
