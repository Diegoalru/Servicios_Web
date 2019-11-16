using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WApp
{
    public partial class TRANSACCION : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MENU.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            WSDB.BDSoapClient WS = new WSDB.BDSoapClient();
            WS.IngresaMovimiento(TextBox1.Text, TextBox2.Text, Double.Parse (TextBox3.Text)  );







        }
    }
}