using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    /// <summary>
    /// Interfas utilizada con clases 
    /// genericas para implementar en
    /// las demas clases
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface I_CRUD<T>
    {
        void Insertar(T obj);
        void Actualizar(T obj);
        void Eliminar(int id);
        T SeleccionarPorID(int id);
        List<T> SeleccionarTodos();
    }
}
