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
        protected void Page_Load(object sender, EventArgs e)
        {
            //WSDB.BDSoapClient WS = new WSDB.BDSoapClient();
            //DataSet ds = WS.GetData();
            //GridView1.DataSource = ds.Tables[0];
            //GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            Response.Redirect("https://www.google.com");



    }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String valor = "";
            WSDB.BDSoapClient WS = new WSDB.BDSoapClient();
            valor=WS.ConsultarClave(TextBox1.Text, TextBox2.Text);

            if (valor == "1") {
                Response.Redirect("MENU.aspx");
            }



            



        }
    }

}