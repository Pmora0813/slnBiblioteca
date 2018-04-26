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
    /// CRUD en la BD de lOS ObjetoS LIBRO y AUTOR
    /// relacionados
    /// </summary>
    public class Libro_Autor_Logica
    {
        public void guardar(Libros idLibro, Autor idAut)
        {
            if (String.IsNullOrWhiteSpace(idLibro.ToString()))
            {
                throw new ApplicationException("El Codigo del libro es requerido");
            }

            if (String.IsNullOrWhiteSpace(idAut.ToString()))
            {
                throw new ApplicationException("El Codigo del Autor es requerido");
            }
            Datos.Libro_Autor_Datos datos = new Datos.Libro_Autor_Datos();

            datos.Insertar(idLibro, idAut);

        }

        public void Eliminar(Libros libro, Autor autor)
        {
            Datos.Libro_Autor_Datos datos = new Datos.Libro_Autor_Datos();
            datos.Eliminar(libro,autor);
        }

        public List<Autor> SeleccionarTodos(int id)
        {
            Datos.Libro_Autor_Datos datos = new Datos.Libro_Autor_Datos();
            return datos.SeleccionarAutorPorLibro(id);
        }
    }
}
