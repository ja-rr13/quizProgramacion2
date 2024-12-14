using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace quiz1.capa_logica
{
    public class Escuela
    {
        public static int AgregarEscuela( string nombreEscuela,string descripcion, string correo, string telefono,string codigo,string direccionPostal)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Agregarescuela", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                   
                    cmd.Parameters.Add(new SqlParameter("@nombreEscuela", nombreEscuela));
                    cmd.Parameters.Add(new SqlParameter("@descripcion", descripcion));
                    cmd.Parameters.Add(new SqlParameter("@correo", correo));                 
                    cmd.Parameters.Add(new SqlParameter("@telefono", telefono));
                    cmd.Parameters.Add(new SqlParameter("@codigopostal", codigo));
                    cmd.Parameters.Add(new SqlParameter("@direccionPostal", direccionPostal));


                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public static int EliminarEscuela(int ID)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("borararEscuela", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@id", ID));




                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public static int ModificarEscuela(int id,string nombreEscuela, string descripcion, string correo, string telefono, string codigo, string direccionPostal)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("modificarEscuela", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.Parameters.Add(new SqlParameter("@nombreEscuela", nombreEscuela));
                    cmd.Parameters.Add(new SqlParameter("@descripcion", descripcion));
                    cmd.Parameters.Add(new SqlParameter("@correo", correo));
                    cmd.Parameters.Add(new SqlParameter("@telefono", telefono));
                    cmd.Parameters.Add(new SqlParameter("@codigopostal", codigo));
                    cmd.Parameters.Add(new SqlParameter("@direccionPostal", direccionPostal));




                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public static int ConsultarEscuela(int ID)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("consultarescuela", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@ID", ID));




                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
    }
}
