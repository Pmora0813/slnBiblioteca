using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class Libro_Datos : I_CRUD<Libros>
    {
        /// <summary>
        /// Insertamos un Autor en la Tabla
        /// de la BD
        /// </summary>
        /// <param name="libro"></param>
        public void Insertar(Libros libro)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {

                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion SP
                string sql = "SP_Libros_Insert";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id", libro.Id);
                comando.Parameters.AddWithValue("@Titulo", libro.Titulo);
                comando.Parameters.AddWithValue("@disponibles", libro.Cant_Disponibles);
                comando.Parameters.AddWithValue("@QR", libro.Qr);
                comando.Parameters.AddWithValue("@id_Editorial",libro.IdEditorial);


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
        /// Actualizamos un registro en la tabla Autor
        /// en la BD
        /// </summary>
        /// <param name="libro"></param>
        public void Actualizar(Libros libro)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Libros_Update";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id", libro.Id);
                comando.Parameters.AddWithValue("@Titulo", libro.Titulo);
                comando.Parameters.AddWithValue("@disponibles", libro.Cant_Disponibles);
                comando.Parameters.AddWithValue("@QR", libro.Qr);
                comando.Parameters.AddWithValue("@id_Editorial", libro.IdEditorial);

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
        public void Eliminar(int Id)
        {

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Libros_DeleteRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id", Id);
                //comando.Parameters.AddWithValue("@Nombre", cat.Nombre);

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
        /// Optenemos un Autor
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Libros SeleccionarPorID(int Id)
        {
            Libros lib = null;

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Libros_SelectRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Id", Id);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    lib = new Libros
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Titulo = reader["titulo"].ToString(),
                        Cant_Disponibles = Convert.ToInt32(reader["disponibles"]),
                        Qr = reader["QR"].ToString(),
                        IdEditorial = Convert.ToInt32(reader["id_Editorial"])
                  
                    };


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

            return lib;

        }
        /// <summary>
        /// Optenemos una lista con todos los Autores
        /// que se encuentran en la BD
        /// </summary>
        /// <returns></returns>
        public List<Libros> SeleccionarTodos()
        {
            List<Libros> lista = new List<Libros>();

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Libros_SelectAll";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Libros lib = new Libros
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Titulo = reader["titulo"].ToString(),
                        Cant_Disponibles = Convert.ToInt32(reader["disponibles"]),
                        Qr = reader["QR"].ToString(),
                        IdEditorial = Convert.ToInt32(reader["id_Editorial"])
                    };

                    lista.Add(lib);

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
