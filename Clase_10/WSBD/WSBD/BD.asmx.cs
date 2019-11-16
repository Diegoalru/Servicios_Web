using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;


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

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataSet GetData()
        {
            SqlConnection conn = new SqlConnection() ;
            conn.ConnectionString = "Data Source=604-PROF ; Initial Catalog='TEST'; Trusted_Connection = True; ";
            
            SqlDataAdapter da= new SqlDataAdapter("SELECT * FROM TBL_USERS", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        [WebMethod]
        public DataSet GetDataMovtos()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=604-PROF; Initial Catalog='TEST'; Trusted_Connection = True; ";

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_CUENTASMOVTOS", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }





        [WebMethod]
        public String ConsultarClave(String Usr, String Pwd)
        {
            String abc = "";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=604-PROF; Initial Catalog='TEST'; Trusted_Connection = True; ";

            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(USERNAME) as DATA FROM TBL_Users WHERE USERNAME='" 
                + Usr +  "' AND PASSWORD='" + Pwd + "'", conn);

            DataSet ds = new DataSet();
            
            da.Fill(ds);
            abc= ds.Tables[0].Rows[0]["DATA"].ToString();
            return abc;
        }


        //[WebMethod]
        //public void IngresaMovimiento(String ID_CUENTA, String ID_MOVIMIENTO, Double MONTO_MOVTO)
        //{
        //    String abc = "";
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = "Data Source=BABYLON7\\S14; Initial Catalog='TEST';User Id=ssu;Password=I9m8N_66";

        //    SqlDataAdapter da = new SqlDataAdapter("INSERT INTO TBL_CUENTASMOVTOS ( ID_CUENTA, ID_MOVTO, MONTO_MOVTO) VALUES ( " + ID_CUENTA +  ", " + ID_MOVIMIENTO + ", "  + MONTO_MOVTO +  " )", conn);
        //    DataSet ds = new DataSet();

        //    da.Fill(ds);

        //    abc = ds.Tables[0].Rows[0]["DATA"].ToString();
            

        //}

        [WebMethod]
        public void IngresaMovimiento(String ID_CUENTA, String ID_MOVTO, Double MONTO_MOVTO)
        {
            /*string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;*/
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=604-PROF; Initial Catalog='TEST'; Trusted_Connection = True; ";

            using (SqlCommand cmd = new SqlCommand("INSERT INTO TBL_CUENTASMOVTOS (ID_CUENTA, ID_MOVTO, MONTO_MOVTO) " +
                " VALUES (@ID_CUENTA, @ID_MOVTO, @MONTO_MOVTO)"))
                
            {
                cmd.Parameters.AddWithValue("@ID_CUENTA", ID_CUENTA);
                cmd.Parameters.AddWithValue("@ID_MOVTO", ID_MOVTO);
                cmd.Parameters.AddWithValue("@MONTO_MOVTO", MONTO_MOVTO);
                
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            
        }


    }
}
