using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;

namespace WSBD
{
    /// <summary>
    /// Descripción breve de BD
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class BD : System.Web.Services.WebService
    {
        #region Metodos_Prueba
        /// <summary>
        /// Metodo de prueba.
        /// </summary>
        /// <returns>Mensaje de prueba.</returns>
        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        #endregion

        #region Usuarios
        /// <summary>
        /// Obtiene la información de la tabla Usuarios.
        /// </summary>
        /// <returns>Información de la tabla usuarios</returns>
        [WebMethod]
        public DataSet GetUsuarios()
        {
            SqlConnection conn = new SqlConnection();
            String query = "SELECT * FROM TBL_Users;";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);
            conn.Close();
            return ds;
        }

        /// <summary>
        /// Metodo que valida las credenciales
        /// </summary>
        /// <param name="username">Nombre de usuario</param>
        /// <param name="password">Contraseña del usuario</param>
        /// <returns>Retorna <code>True</code> en caso de que las credenciales existan en la base de datos.</returns>
        [WebMethod]
        public Boolean Login(String username, String password)
        {
            try
            {
                SqlConnection conn;
                bool exists;        //Creamos bool para retornar.
                string query = string.Format("SELECT USERNAME FROM TBL_Users WHERE USERNAME = '{0}' AND PASSWORD = '{1}';", username, password);
                //Abrimos la conexion con la base de datos.
                using (conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();//Abrimos la base de datos.
                        SqlDataReader result = cmd.ExecuteReader();
                        //Si la tabla virtual contiene datos.
                        if (result.HasRows)
                        {
                            //Accion de acceso correcto.
                            exists = true;
                        }
                        //Si la consulta no devolvio datos.
                        else
                        {
                            //Acción de acceso fallido.
                            exists = false;
                        }
                        conn.Close();//Cerramos la base de datos.
                    }
                }
                return exists;//Retornamos el objeto booleano.
            }
            catch (SqlException)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
                return false;
            }
        }
        #endregion
        
        #region Movimientos

        /* TODO: Crear metodo para buscar datos individuales.
         */


        /// <summary>
        /// Metodo que devuelve todos los Movimientos.
        /// </summary>
        /// <returns>Retorna un <code>DataSet</code> con los datos de la tabla Movimientos.</returns>
        [WebMethod]
        public DataSet GetMovimientos()
        {
            try
            {
                DataSet ds = new DataSet();
                string query = string.Format(@"
                    SELECT
                        ID_CUENTA AS CUENTA
                        ,ID_MOVTO AS MOVIMIENTO
                        ,MONTO_MOVTO AS MONTO
                        ,CONCAT(FECHA, ' ', HORA) AS [FECHA Y HORA]
                    FROM 
                        TBL_CUENTASMOVTOS;");
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(ds);
                        }
                        conn.Close();
                    }
                }
                return ds;
            }
            catch (SqlException)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
                return null;
            }
        }

        /// <summary>
        /// Metodo que se encarga de ingresar movimientos.
        /// </summary>
        /// <param name="cuenta">Id de la cuenta.</param>
        /// <param name="movimiento">Id del movimiento.</param>
        /// <param name="monto">Monto del moviento.</param>
        [WebMethod]
        public void IngresaMovimiento(string id_cuenta, string id_movimiento, double monto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(@"
                            INSERT 
                                INTO 
                                    TBL_CUENTASMOVTOS 
                                        (
                                         ID_CUENTA
                                         ,ID_MOVTO
                                         ,MONTO_MOVTO
                                         ,FECHA
                                         ,HORA
                                         )
                                VALUES 
                                         (
                                         @ID_CUENTA
                                         ,@ID_MOVTO
                                         ,@MONTO_MOVTO
                                         ,@FECHA
                                         ,@HORA
                                         );"))
                    {
                        cmd.Parameters.AddWithValue("@ID_CUENTA", id_cuenta);
                        cmd.Parameters.AddWithValue("@ID_MOVTO", id_movimiento);
                        cmd.Parameters.AddWithValue("@MONTO_MOVTO", monto);
                        cmd.Parameters.AddWithValue("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                        cmd.Parameters.AddWithValue("@HORA", DateTime.Now.ToString("hh:mm:ss"));

                        cmd.Connection = conn;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (SqlException)
            {
                Console.Write("Ha ocurrido un error.\n");
            }

        }

        [WebMethod]
        public void EliminaMovimiento(string id_movimiento)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(@"
                            DELETE 
                                FROM 
                                    TBL_CUENTASMOVTOS 
                                WHERE 
                                    ID_MOVTO = @ID_MOVTO;"))
                    {
                        cmd.Parameters.AddWithValue("@ID_MOVTO", id_movimiento);

                        cmd.Connection = conn;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (SqlException)
            {
                Console.Write("Ha ocurrido un error.\n");
            }
        }

        #endregion



    }
}
