using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class Estudiante_Logica
    {
        public void guardar(Estudiante estudiante)
        {
            if (String.IsNullOrWhiteSpace(estudiante.Nombre))
            {
                throw new ApplicationException("El nombre es requerido");
            }
            Datos.Estudiante_Datos datos = new Datos.Estudiante_Datos();
            if (datos.SeleccionarPorID(estudiante.IdCedula) == null)
                datos.Insertar(estudiante);
            else
                datos.Actualizar(estudiante);
        }

        public List<Estudiante> SeleccionarTodos()
        {
            Datos.Estudiante_Datos datos = new Datos.Estudiante_Datos();
            return datos.SeleccionarTodos();
        }
        public Estudiante SeleccionarEstudiantePorId(int Id)
        {
            Datos.Estudiante_Datos datos = new Datos.Estudiante_Datos();
            return datos.SeleccionarPorID(Id);
        }

        public void Eliminar(int Id)
        {
            Datos.Estudiante_Datos datos = new Datos.Estudiante_Datos();
            datos.Eliminar(Id);
        }
    }
}
