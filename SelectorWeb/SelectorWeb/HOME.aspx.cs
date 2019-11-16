using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SelectorWeb
{
    public partial class HOME : System.Web.UI.Page
    {

        private cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos service = new cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CarcagrDatos_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtener el indentificador
                int cod;
                cod = GetCode();

                //Limpiar datos anteriores.
                GridView1.DataSource = null;
                GridView1.DataBind();

                //Obtener datos.
                DataSet ds = service.ObtenerIndicadoresEconomicos(cod.ToString(), Txt_FechaInicio.Text, Txt_FechaFinal.Text, "Diego Rubí S", "N");

                //Mostrar datos.
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();

                //Limpiar los cuadros de texto.
                LimpiaCuadrosTexto();
            }
            catch (Exception)
            {
                Txt_Result.Text = "Error al realizar la consulta.";
            }
            Btn_CargarDatos.Text = "Reintentar";
        }

        private int GetCode()
        {
            int result = 0;
            switch (Rdb_Indicadores.SelectedIndex)
            {
                case 0:
                    result = 317;
                    break;
                case 1:
                    result = 318;
                    break;
                case 2:
                    result = 333;
                    break;
                case 3:
                    result = 325;
                    break;
                case 4:
                    result = 338;
                    break;
            }
            return result;
        }

        private void LimpiaCuadrosTexto()
        {
            Txt_FechaInicio.Text = String.Empty;
            Txt_FechaFinal.Text = String.Empty;
            Txt_Result.Text = String.Empty;
        }

    }
}