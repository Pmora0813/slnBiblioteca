using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class Prestamo_Datos : I_CRUD<Prestamo>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prestamo"></param>
        public void Insertar(Prestamo prestamo)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {

                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion SP
                string sql = "SP_Prestamos_Insert";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id", prestamo.id);
                comando.Parameters.AddWithValue("@fecha_Act", prestamo.Fecha_Act);
                comando.Parameters.AddWithValue("@fecha_Dev", prestamo.Fecha_Dev);
                comando.Parameters.AddWithValue("@minutos_Dev", prestamo.minutos);
                comando.Parameters.AddWithValue("@horas_Dev", prestamo.horas);
                comando.Parameters.AddWithValue("@dias_Dev", prestamo.dias);
                comando.Parameters.AddWithValue("@ID_ESTUDIANTE", prestamo.estudiant.IdCedula);
                //comando.Parameters.AddWithValue("@ID_LIBRO", prestamo.Libro.Id);
                comando.Parameters.AddWithValue("@ID_USUARIO", prestamo.Usuario.id);
                comando.Parameters.AddWithValue("@ID_CATEGORIA", prestamo.Categoria.Id);

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
        /// <param name="prestamo"></param>
        public void Actualizar(Prestamo prestamo)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Prestamos_Update";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id", prestamo.id);
                comando.Parameters.AddWithValue("@fecha_Act", prestamo.Fecha_Act);
                comando.Parameters.AddWithValue("@fecha_Dev", prestamo.Fecha_Dev);
                comando.Parameters.AddWithValue("@minutos_Dev", prestamo.minutos);
                comando.Parameters.AddWithValue("@horas_Dev", prestamo.horas);
                comando.Parameters.AddWithValue("@dias_Dev", prestamo.dias);
                comando.Parameters.AddWithValue("@ID_ESTUDIANTE", prestamo.estudiant.IdCedula);
                // comando.Parameters.AddWithValue("@ID_LIBRO", prestamo.Libro.Id);
                comando.Parameters.AddWithValue("@ID_USUARIO", prestamo.Usuario.id);
                comando.Parameters.AddWithValue("@ID_CATEGORIA", prestamo.Categoria.Id);

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
                string sql = "SP_Prestamos_DeleteRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@Id", Id);
                //comando.Parameters.AddWithValue("@Nombre", prestamo.Nombre);

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
        /// Optenemos un Prestamo de la tabla
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Prestamo SeleccionarPorID(int Id)
        {
            Prestamo prestamo = null;

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Prestamos_SelectRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Id", Id);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    prestamo = new Prestamo
                    {
                        id = Convert.ToInt32(reader["Id"]),
                        Fecha_Act = Convert.ToDateTime(reader["fecha_Act"]),
                        Fecha_Dev = Convert.ToDateTime(reader["fecha_Dev"]),
                        minutos = Convert.ToInt32(reader["minutos_Dev"]),
                        horas = Convert.ToInt32(reader["horas_Dev"]),
                        dias = Convert.ToInt32(reader["dias_Dev"]),
                        estudiant = new Estudiante_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_ESTUDIANTE"])),
                        //Libro = new Libro_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_LIBRO"])),
                        Usuario = new Usuario_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_USUARIO"])),
                        Categoria = new Categoria_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_CATEGORIA"]))
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

            return prestamo;

        }
        /// <summary>
        /// Optenemos una lista con todos los Autores
        /// que se encuentran en la BD
        /// </summary>
        /// <returns></returns>
        public List<Prestamo> SeleccionarTodos()
        {
            List<Prestamo> lista = new List<Prestamo>();

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Prestamos_SelectAll";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Prestamo prestamo = new Prestamo
                    {
                        id = Convert.ToInt32(reader["Id"]),
                        Fecha_Act = Convert.ToDateTime(reader["fecha_Act"]),
                        Fecha_Dev = Convert.ToDateTime(reader["fecha_Dev"]),
                        minutos = Convert.ToInt32(reader["minutos_Dev"]),
                        horas = Convert.ToInt32(reader["horas_Dev"]),
                        dias = Convert.ToInt32(reader["dias_Dev"]),
                        estudiant = new Estudiante_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_ESTUDIANTE"])),
                        //Libro = new Libro_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_LIBRO"])),
                        Usuario = new Usuario_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_USUARIO"])),
                        Categoria = new Categoria_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_CATEGORIA"]))
                    };

                    lista.Add(prestamo);

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
        /// <summary>
        /// Metodo que optiene todos los prestamos
        /// que se encuentran en la BD 
        /// pendientes de Devolucion
        /// </summary>
        /// <returns></returns>
        public List<Prestamo> Solicitudes_Devolucion()
        {
            List<Prestamo> lista = new List<Prestamo>();

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Prestamos_Solic_Devol";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);
                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Prestamo prestamo = new Prestamo
                    {
                        id = Convert.ToInt32(reader["Id"]),
                        Fecha_Act = Convert.ToDateTime(reader["fecha_Act"]),
                        Fecha_Dev = Convert.ToDateTime(reader["fecha_Dev"]),
                        minutos = Convert.ToInt32(reader["minutos_Dev"]),
                        horas = Convert.ToInt32(reader["horas_Dev"]),
                        dias = Convert.ToInt32(reader["dias_Dev"]),
                        estudiant = new Estudiante_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_ESTUDIANTE"])),
                        //Libro = new Libro_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_LIBRO"])),
                        Usuario = new Usuario_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_USUARIO"])),
                        Categoria = new Categoria_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_CATEGORIA"]))
                    };

                    lista.Add(prestamo);

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
        /// <summary>
        /// Metodo que todos los prestamos de libros
        /// que tiene una solitud de prestamo
        /// </summary>
        /// <returns></returns>
        public List<Prestamo> Solicitudes_Prestamo()
        {
            List<Prestamo> lista = new List<Prestamo>();

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Prestamos_Solic_Prestamo";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);
                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Prestamo prestamo = new Prestamo
                    {
                        id = Convert.ToInt32(reader["Id"]),
                        Fecha_Act = Convert.ToDateTime(reader["fecha_Act"]),
                        Fecha_Dev = Convert.ToDateTime(reader["fecha_Dev"]),
                        minutos = Convert.ToInt32(reader["minutos_Dev"]),
                        horas = Convert.ToInt32(reader["horas_Dev"]),
                        dias = Convert.ToInt32(reader["dias_Dev"]),
                        estudiant = new Estudiante_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_ESTUDIANTE"])),
                        Usuario = new Usuario_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_USUARIO"])),
                        Categoria = new Categoria_Datos().SeleccionarPorID(Convert.ToInt32(reader["ID_CATEGORIA"]))
                    };

                    lista.Add(prestamo);

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

