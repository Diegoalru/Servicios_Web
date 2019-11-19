using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WApp
{
    public partial class Home : System.Web.UI.Page
    {

        /* LISTA DE TAREAS:
         * TODO: Crear login.
         * TODO: Crear paginas para modificar y eliminar.
         * 
         */

        protected void Page_Load(object sender, EventArgs e)
        {
            //MuestraUsuarios();
        }

        [Obsolete("Metodo que obtiene una lista con los usuarios de la BD.", true)]
        private void MuestraUsuarios()
        {
            //com.wsbd.www.BD WS = new com.wsbd.www.BD();
            //DataSet ds = WS.GetUsuarios();
            //Grd_Usuarios.DataSource = ds.Tables[0];
            //Grd_Usuarios.DataBind();
        }
        
        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            com.wsbd.www.BD WS = new com.wsbd.www.BD();
            if (WS.Login(Txt_Usuario.Text, Txt_Clave.Text))
                Response.Redirect("./Pages/Total_Movimientos.aspx");
            else
                Lbl_Message.Text = "¡Error! Usuario o clave incorrecta.";
        }
    }
}