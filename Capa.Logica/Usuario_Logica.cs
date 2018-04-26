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
    /// CRUD en la BD del Objeto USUARIO
    /// </summary>
    public class Usuario_Logica
    {
    
    public void guardar(Usuario usuario)
    {
            if (String.IsNullOrWhiteSpace(usuario.id.ToString()))
        {
            throw new ApplicationException("El nombre es requerido");
        }
        Datos.Usuario_Datos datos = new Datos.Usuario_Datos();
        if (datos.SeleccionarPorID(usuario.id) == null)
            datos.Insertar(usuario);
        else
            datos.Actualizar(usuario);
    }

    public List<Usuario> SeleccionarTodos()
    {
        Datos.Usuario_Datos datos = new Datos.Usuario_Datos();
        return datos.SeleccionarTodos();
    }
    public Usuario SeleccionarCategoriaPorId(int Id)
    {
        Datos.Usuario_Datos datos = new Datos.Usuario_Datos();
        return datos.SeleccionarPorID(Id);
    }

    public void Eliminar(int Id)
    {
        Datos.Usuario_Datos datos = new Datos.Usuario_Datos();
        datos.Eliminar(Id);
    }
}
}
