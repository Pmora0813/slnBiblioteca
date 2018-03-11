using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class Editorial_Datos
    {
            /// <summary>
            /// Insertamos un Autor en la Tabla
            /// de la BD
            /// </summary>
            /// <param name="edit"></param>
            public void Insertar(Editorial edit)
            {
                //Paso 1: conexion BD
                SqlConnection conexion = new SqlConnection(Conexion.Cadena);

                try
                {

                    //Abrir la conexion
                    conexion.Open();
                    //Paso 2: Instruccion SP
                    string sql = "SP_Editorial_Insert";

                    //Paso 3: Comando para ejecutar el paso 2
                    SqlCommand comando = new SqlCommand(sql, conexion);

                    //Paso 4: Enviar los parametros
                    comando.Parameters.AddWithValue("@Id", edit.Id);
                    comando.Parameters.AddWithValue("@descripcion", edit.Nombre);

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
            /// <param name="edit"></param>
            public void Actualizar(Editorial edit)
            {
                //Paso 1: conexion BD
                SqlConnection conexion = new SqlConnection(Conexion.Cadena);

                try
                {
                    //Abrir la conexion
                    conexion.Open();
                    //Paso 2: Instruccion
                    string sql = "SP_Editorial_Update";

                    //Paso 3: Comando para ejecutar el paso 2
                    SqlCommand comando = new SqlCommand(sql, conexion);

                    //Paso 4: Enviar los parametros
                    comando.Parameters.AddWithValue("@Id", edit.Id);
                    comando.Parameters.AddWithValue("@descripcion", edit.Nombre);

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
                    string sql = "SP_Editorial_DeleteRow";

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
            public Editorial SeleccionarEditorialPorID(int Id)
            {
            Editorial edit = null;

                //Paso 1: conexion BD
                SqlConnection conexion = new SqlConnection(Conexion.Cadena);

                try
                {
                    //Abrir la conexion
                    conexion.Open();
                    //Paso 2: Instruccion
                    string sql = "SP_Editorial_SelectRow";

                    //Paso 3: Comando para ejecutar el paso 2
                    SqlCommand comando = new SqlCommand(sql, conexion);

                    comando.Parameters.AddWithValue("@Id", Id);

                    //Paso 4.1: Usar el Procedimineto Almacenado
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {

                        edit = new Editorial
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = reader["descripcion"].ToString()
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

                return edit;

            }
            /// <summary>
            /// Optenemos una lista con todos los Autores
            /// que se encuentran en la BD
            /// </summary>
            /// <returns></returns>
            public List<Editorial> SeleccionarEditoriales()
            {
                List<Editorial> lista = new List<Editorial>();

                //Paso 1: conexion BD
                SqlConnection conexion = new SqlConnection(Conexion.Cadena);

                try
                {
                    //Abrir la conexion
                    conexion.Open();
                    //Paso 2: Instruccion
                    string sql = "SP_Editorial_SelectAll";

                    //Paso 3: Comando para ejecutar el paso 2
                    SqlCommand comando = new SqlCommand(sql, conexion);

                    //Paso 4.1: Usar el Procedimineto Almacenado
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Editorial edit = new Editorial
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = reader["descripcion"].ToString()
                        };

                        lista.Add(edit);

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
