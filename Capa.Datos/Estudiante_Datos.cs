using Capa.Entidades;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class Estudiante_Datos : I_CRUD<Estudiante>
    {
        /// <summary>
        /// Insertamos un Autor en la Tabla
        /// de la BD
        /// </summary>
        /// <param name="estudiante"></param>
        public void Insertar(Estudiante estudiante)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {

                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion SP
                string sql = "SP_Estudiante_Insert";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@id_Cedula", estudiante.IdCedula);
                comando.Parameters.AddWithValue("@contrasenna", estudiante.Contrasenna);
                comando.Parameters.AddWithValue("@nombre", estudiante.Nombre);
                comando.Parameters.AddWithValue("@seccion", estudiante.Seccion);
                comando.Parameters.AddWithValue("@genero", estudiante.Genero);
                comando.Parameters.AddWithValue("@fecha_Nacimiento", estudiante.F_Nacimiento);
                comando.Parameters.AddWithValue("@email", estudiante.Email);
                comando.Parameters.AddWithValue("@telefono", estudiante.Telefono);
                comando.Parameters.AddWithValue("@activo", estudiante.Activo);
                comando.Parameters.AddWithValue("@QR", estudiante.QR);
                comando.Parameters.AddWithValue("@ID_ROL", estudiante.Roll.id);


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
        /// <param name="estudiante"></param>
        public void Actualizar(Estudiante estudiante)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Estudiante_Update";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@id_Cedula", estudiante.IdCedula);
                comando.Parameters.AddWithValue("@contrasenna", estudiante.Contrasenna);
                comando.Parameters.AddWithValue("@nombre", estudiante.Nombre);
                comando.Parameters.AddWithValue("@seccion", estudiante.Seccion);
                comando.Parameters.AddWithValue("@genero", estudiante.Genero);
                comando.Parameters.AddWithValue("@fecha_Nacimiento", estudiante.F_Nacimiento);
                comando.Parameters.AddWithValue("@email", estudiante.Email);
                comando.Parameters.AddWithValue("@telefono", estudiante.Telefono);
                comando.Parameters.AddWithValue("@activo", estudiante.Activo);
                comando.Parameters.AddWithValue("@QR", estudiante.QR);
                comando.Parameters.AddWithValue("@ID_ROL", estudiante.Roll.id);

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
                string sql = "SP_Estudiante_DeleteRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id_Cedula", Id);
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
        public Estudiante SeleccionarPorID(int Id)
        {
            Estudiante estudiante = null;

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Estudiante_SelectRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Id_Cedula", Id);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    estudiante = new Estudiante
                    {
                        IdCedula = Convert.ToInt32(reader["Id_Cedula"]),
                        Contrasenna = reader["contrasenna"].ToString(),
                        Nombre = reader["nombre"].ToString(),
                        Seccion = reader["seccion"].ToString(),
                        Genero = reader["genero"].ToString(),
                        F_Nacimiento = Convert.ToDateTime(reader["fecha_Nacimiento"]),
                        Email = reader["email"].ToString(),
                        Telefono = Convert.ToInt32(reader["telefono"]),
                        Activo = Convert.ToBoolean(reader["activo"]),
                        QR = reader["QR"].ToString(),
                        Roll = new Rol_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_ROL"]))
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

            return estudiante;

        }
        /// <summary>
        /// Optenemos una lista con todos los Autores
        /// que se encuentran en la BD
        /// </summary>
        /// <returns></returns>
        public List<Estudiante> SeleccionarTodos()
        {
            List<Estudiante> lista = new List<Estudiante>();

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Estudiante_SelectAll";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Estudiante estudiante = new Estudiante
                    {
                        IdCedula = Convert.ToInt32(reader["Id_Cedula"]),
                        Contrasenna = reader["contrasenna"].ToString(),
                        Nombre = reader["nombre"].ToString(),
                        Seccion = reader["seccion"].ToString(),
                        Genero = reader["genero"].ToString(),
                        F_Nacimiento = Convert.ToDateTime(reader["fecha_Nacimiento"]),
                        Email = reader["email"].ToString(),
                        Telefono = Convert.ToInt32(reader["telefono"]),
                        Activo = Convert.ToBoolean(reader["activo"]),
                        QR = reader["QR"].ToString(),
                        Roll = new Rol_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_ROL"]))
                    };


                    lista.Add(estudiante);

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
