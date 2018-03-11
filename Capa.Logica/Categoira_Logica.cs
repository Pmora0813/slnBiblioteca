using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class Categoira_Logica
    {
        public void guardar(Categoria cat)
        {
            if (String.IsNullOrWhiteSpace(cat.Descripcion))
            {
                throw new ApplicationException("El nombre es requerido");
            }
            Datos.Categoria_Datos datos = new Datos.Categoria_Datos();
            if (datos.SeleccionarCategoriaPorID(cat.Id) == null)
                datos.Insertar(cat);
            else
                datos.Actualizar(cat);
        }

        public List<Categoria> SeleccionarTodos()
        {
            Datos.Categoria_Datos datos = new Datos.Categoria_Datos();
            return datos.SeleccionarCategorias();
        }
        public Categoria SeleccionarCategoriaPorId(int Id)
        {
            Datos.Categoria_Datos datos = new Datos.Categoria_Datos();
            return datos.SeleccionarCategoriaPorID(Id);
        }

        public void Eliminar(int Id)
        {
            Datos.Categoria_Datos datos = new Datos.Categoria_Datos();
            datos.Eliminar(Id);
        }
    }
}
