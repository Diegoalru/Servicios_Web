using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WApp.Pages
{
    public partial class Borra_Movimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                com.wsbd.www.BD WS = new com.wsbd.www.BD();
                WS.EliminaMovimiento(Txt_Movimiento.Text);
                Lbl_Mensaje.ForeColor = System.Drawing.Color.Green;
                Lbl_Mensaje.Text = $"El movimiento con el ID: {Txt_Movimiento.Text} fue eliminado exitosamente!.";
            }
            catch (Exception ex)
            {
                Lbl_Mensaje.ForeColor = System.Drawing.Color.Red;
                Lbl_Mensaje.Text = $"¡Error! {ex.Message}";
            }
        }
    }
}