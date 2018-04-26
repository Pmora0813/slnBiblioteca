using Capa.Datos;
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
    /// CRUD en la BD del Objeto LIBRO
    /// Como tambien la busqueda de libros por un 
    /// filtro de datos
    /// </summary>
    public class Libro_Logica
    {
        public void Actualizar(Libros obj)
        {
            Libro_Datos datos = new Libro_Datos();
            datos.Actualizar(obj);
        }

        public void Eliminar(int id)
        {
            Libro_Datos datos = new Libro_Datos();
            datos.Eliminar(id);
        }

        public void Insertar(Libros obj)
        {
            Libro_Datos datos = new Libro_Datos();
            datos.Insertar(obj);
        }

        public Libros SeleccionarPorID(int id)
        {
            Libro_Datos datos = new Libro_Datos();
            return datos.SeleccionarPorID(id);
        }

        public List<Libros> SeleccionarTodos()
        {
            Libro_Datos datos = new Libro_Datos();
            return datos.SeleccionarTodos();
        }

        public List<Libros> SeleccionarTodosFiltro(int id, string titulo, int idAutor, int idEditorial, int anno)
        {
            Libro_Datos datos = new Libro_Datos();
            return datos.SeleccionarTodosFiltro(id,titulo,idAutor,idEditorial,anno);
        }
    }
}
