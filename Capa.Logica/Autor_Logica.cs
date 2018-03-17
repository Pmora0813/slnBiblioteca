using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
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

        /// <summary>
        /// Metodos de la tabla de Libro Autores
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
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
    }
}
