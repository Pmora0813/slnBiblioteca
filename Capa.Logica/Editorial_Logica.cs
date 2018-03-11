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
            if (datos.SeleccionarEditorialPorID(edit.Id) == null)
                datos.Insertar(edit);
            else
                datos.Actualizar(edit);
        }

        public List<Editorial> SeleccionarTodos()
        {
            Datos.Editorial_Datos datos = new Datos.Editorial_Datos();
            return datos.SeleccionarEditoriales();
        }
        public Editorial SeleccionarCategoriaPorId(int Id)
        {
            Datos.Editorial_Datos datos = new Datos.Editorial_Datos();
            return datos.SeleccionarEditorialPorID(Id);
        }

        public void Eliminar(int Id)
        {
            Datos.Editorial_Datos datos = new Datos.Editorial_Datos();
            datos.Eliminar(Id);
        }
    }
}
