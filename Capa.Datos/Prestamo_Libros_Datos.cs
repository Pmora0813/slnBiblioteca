using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class Prestamo_Libros_Datos
    {
        public void Insertar(Prestamo prestamo, Libros libro)
        {
            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {

                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion SP
                string sql = "SP_Libro_Prestamo_Insert";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@ID_PRESTAMO", prestamo.id);
                comando.Parameters.AddWithValue("@ID_LIBRO", libro.Id);

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
        public void Eliminar(Prestamo prestamo, Libros libro)
        {

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Libro_Prestamo_DeleteRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4: Enviar los parametros
                comando.Parameters.AddWithValue("@ID_PRESTAMO", prestamo.id);
                comando.Parameters.AddWithValue("@ID_LIBRO", libro.Id);

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


        public List<Libros> SeleccionarLibroPorPrestamo(int idPrestamo)
        {
            Libros libro = null;
            List<Libros> lista = new List<Libros>();

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Libros_Por_PrestamoID";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", idPrestamo);

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    libro = new Libros
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Titulo = reader["titulo"].ToString(),
                        anno = Convert.ToInt32(reader["anno"]),
                     //   Qr = reader["QR"].ToString(),
                        Editorial = new Editorial_Datos().SeleccionarPorID(Convert.ToInt32(reader["id_Editorial"]))
                    };

                    lista.Add(libro);

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
