﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WApp.Pages
{
    public partial class Ingresa_Movimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Insertar_Click(object sender, EventArgs e)
        {
            com.wsbd.www.BD WS = new com.wsbd.www.BD();
            try
            {
                double.TryParse(Txt_Monto.Text, out double monto);
                WS.IngresaMovimiento(Txt_Cuenta.Text, Txt_Movimiento.Text, monto);
                Lbl_Mensaje.ForeColor = System.Drawing.Color.Green;
                Lbl_Mensaje.Text = $"El movimiento con el ID: {Txt_Movimiento.Text} fue ingresado exitosamente!.";
            }
            catch (Exception ex)
            {
                Lbl_Mensaje.ForeColor = System.Drawing.Color.Red;
                Lbl_Mensaje.Text = $"{ex.Message}";
            }
        }
    }
}