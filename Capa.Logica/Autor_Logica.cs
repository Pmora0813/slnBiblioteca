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
    /// CRUD en la BD del Objeto AUTOR
    /// </summary>
    public class Autor_Logica
    {
        public void guardar(Autor aut)
        {
            if (String.IsNullOrWhiteSpace(aut.Nombre))
            {
                throw new ApplicationException("El nombre es requerido");
            }
            Datos.Autor_Datos datos = new Datos.Autor_Datos();
            if (datos.SeleccionarPorID(aut.Id) == null)
                datos.Insertar(aut);
            else
                datos.Actualizar(aut);
        }

        public List<Autor> SeleccionarTodos()
        {
            Datos.Autor_Datos datos = new Datos.Autor_Datos();
            return datos.SeleccionarTodos();
        }

        public Autor SeleccionarAutorPorId(int Id)
        {
            Datos.Autor_Datos datos = new Datos.Autor_Datos();
            return datos.SeleccionarPorID(Id);
        }

        public void Eliminar(int Id)
        {
            Datos.Autor_Datos datos = new Datos.Autor_Datos();
            datos.Eliminar(Id);
        }
               
        public List<Autor> SeleccionarAutorPorLibro(int Id)
        {
            Datos.Libro_Autor_Datos datos = new Datos.Libro_Autor_Datos();
            return datos.SeleccionarAutorPorLibro(Id);
        }

        public void AgregarProveedor(Libros libro, Autor autor)
        {
            Datos.Libro_Autor_Datos datos = new Datos.Libro_Autor_Datos();
            datos.Insertar(libro, autor);
        }

        public List<Autor> SeleccionarTodosFiltro()
        {
            Datos.Autor_Datos datos = new Datos.Autor_Datos();
            var lista = datos.SeleccionarTodos();
            Autor autor = new Autor()
            {
                Id = -1,
                Nombre = "Todos"
            };
            lista.Insert(0, autor);

            return lista;
        }
    }
}
