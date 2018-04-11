using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class Prestamo_Libros_Logica
    {

        public void guardar(Prestamo prestamo, Libros libro)
        {
            try
            {
                Datos.Prestamo_Libros_Datos datos = new Datos.Prestamo_Libros_Datos();

                datos.Insertar(prestamo, libro);
            }

            catch (Exception)
            {

                throw;
            }

        }

        public void Eliminar(Prestamo prestamo, Libros libro)
        {
            try
            {
                Datos.Prestamo_Libros_Datos datos = new Datos.Prestamo_Libros_Datos();
                datos.Eliminar(prestamo, libro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Libros> SeleccionarTodos(int id)
        {
            try
            {
                Datos.Prestamo_Libros_Datos datos = new Datos.Prestamo_Libros_Datos();
                return datos.SeleccionarLibroPorPrestamo(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
