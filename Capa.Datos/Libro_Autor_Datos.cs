using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class Libro_Autor_Datos
    {
        /// <summary>
        /// Insertamos un Autor en la Tabla
        /// de la BD
        /// </summary>
        /// <param name="libro"></param>
        /// <param name="autor"></param>
        public void Insertar(Libros libro, Autor autor)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {

                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion SP
                string sql = "SP_Autor_Libros_Insert";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@ID_LIBRO", libro.Id);
                comando.Parameters.AddWithValue("@ID_AUTOR", autor.Id);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        /// <summary>
        /// Eliminamos un Registro de la Tabla
        /// en la BD por el id 
        /// </summary>
        /// <param name="id"></param>
        public void Eliminar(Libros libro, Autor autor)
        {

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Autor_Libros_DeleteRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@ID_LIBRO", libro.Id);
                comando.Parameters.AddWithValue("@ID_AUTOR", autor.Id);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }


        public List<Autor> SeleccionarAutorPorLibro(int idPorv)
        {
            Autor autor = null;
            List<Autor> lista = new List<Autor>();

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Autor_Por_LibroID";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", idPorv);

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    autor = new Autor
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["descripcion"].ToString()
                    };

                    lista.Add(autor);

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return lista;


        }
    }
}
