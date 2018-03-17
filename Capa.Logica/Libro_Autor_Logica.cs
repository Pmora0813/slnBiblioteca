using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
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

        public void Eliminar(Libros idLibro, Autor idAut)
        {
            Datos.Libro_Autor_Datos datos = new Datos.Libro_Autor_Datos();
            datos.Eliminar(idLibro,idAut);
        }

        public List<Autor> SeleccionarTodos(int id)
        {
            Datos.Libro_Autor_Datos datos = new Datos.Libro_Autor_Datos();
            return datos.SeleccionarAutorPorLibro(id);
        }
    }
}
