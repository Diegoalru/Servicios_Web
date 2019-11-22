using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WApp.Pages
{
    public partial class Actualiza_Movimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                com.wsbd.www.BD WS = new com.wsbd.www.BD();
                double.TryParse(Txt_Monto.Text, out double monto);
                WS.ModificaMovimiento(Txt_Movimiento.Text, monto);
                Lbl_Mensaje.ForeColor = System.Drawing.Color.Green;
                Lbl_Mensaje.Text = $"El movimiento con el ID: {Txt_Movimiento.Text} fue modificado exitosamente!.";
            }
            catch (Exception ex)
            {
                Lbl_Mensaje.ForeColor = System.Drawing.Color.Red;
                Lbl_Mensaje.Text = $"¡Error! {ex.Message}";
            }
        }
    }
}