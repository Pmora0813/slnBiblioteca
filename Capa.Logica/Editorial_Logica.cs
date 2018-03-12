using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class Editorial_Logica
    {
        public void guardar(Editorial edit)
        {
            if (String.IsNullOrWhiteSpace(edit.Nombre))
            {
                throw new ApplicationException("El nombre es requerido");
            }
            Datos.Editorial_Datos datos = new Datos.Editorial_Datos();
            if (datos.SeleccionarPorID(edit.Id) == null)
                datos.Insertar(edit);
            else
                datos.Actualizar(edit);
        }

        public List<Editorial> SeleccionarTodos()
        {
            Datos.Editorial_Datos datos = new Datos.Editorial_Datos();
            return datos.SeleccionarTodos();
        }
        public Editorial SeleccionarCategoriaPorId(int Id)
        {
            Datos.Editorial_Datos datos = new Datos.Editorial_Datos();
            return datos.SeleccionarPorID(Id);
        }

        public void Eliminar(int Id)
        {
            Datos.Editorial_Datos datos = new Datos.Editorial_Datos();
            datos.Eliminar(Id);
        }
    }
}
