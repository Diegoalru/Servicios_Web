using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WApp.Pages
{
    public partial class Total_Movimientos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MuestraUsuarios();
        }

        private void MuestraUsuarios()
        {
            com.wsbd.www.BD WS = new com.wsbd.www.BD();
            DataSet ds = WS.GetMovimientos();
            Grd_TotalMovimientos.DataSource = ds.Tables[0];
            Grd_TotalMovimientos.DataBind();
        }
    }
}