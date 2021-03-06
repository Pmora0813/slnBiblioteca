﻿using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
  public  class Rol_Datos 
    {
        /// <summary>
        /// optenemos todas las 
        /// clasificacionde para el 
        /// acceso al sistema
        /// </summary>
        /// <returns></returns>
        public List<Roll> SeleccionarRoles()
        {
            List<Roll> lista = new List<Roll>();

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Roles_SelectAll";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Roll roll = new Roll
                    {
                        id = Convert.ToInt32(reader["id"]),
                        descripcion = reader["descripcion"].ToString()
                    };

                    lista.Add(roll);

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
        /// Optenemos un Roll
        /// especificado
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Roll SeleccionarPorID(int Id)
        {
            Roll rol = null;

            //Paso 1: conexion BD
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                //Abrir la conexion
                conexion.Open();
                //Paso 2: Instruccion
                string sql = "SP_Roles_SelectRow";

                //Paso 3: Comando para ejecutar el paso 2
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Id", Id);

                //Paso 4.1: Usar el Procedimineto Almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Paso 5: Ejecutar el Comando que permite obtener registros de la tabla
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    rol = new Roll
                    {
                        id = Convert.ToInt32(reader["Id"]),
                        descripcion = reader["descripcion"].ToString()
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

            return rol;

        }
    }
}
