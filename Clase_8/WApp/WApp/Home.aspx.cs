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
            com.wsbd.www.BD WS = new com.wsbd.www.BD();
            DataSet ds = WS.GetMovimientos();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}