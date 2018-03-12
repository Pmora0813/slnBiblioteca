using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public interface I_CRUD<T>
    {
        void Insertar(T obj);
        void Actualizar(T obj);
        void Eliminar(int id);
        T SeleccionarPorID(int id);
        List<T> SeleccionarTodos();
    }
}
