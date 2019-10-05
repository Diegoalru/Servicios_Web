using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsumoBCR.Logic
{
    public class Consulta
    {
        public void ConsultaIndicador(string indicador)
        {
            cr.fi.bccr.gee.wsIndicadoresEconomicos cliente = new cr.fi.bccr.gee.wsIndicadoresEconomicos();
            DataSet Tipocambio = cliente.ObtenerIndicadoresEconomicos(indicador, "5/10/2019", "5/10/2019", "Diego Rubi Salas", "N");
            Console.WriteLine("Código Indicador:    " + Tipocambio.Tables[0].Rows[0].ItemArray[0].ToString());
            Console.WriteLine("Fecha Consulta:  " + Tipocambio.Tables[0].Rows[0].ItemArray[1].ToString());
            Console.WriteLine("Valor:   " + Tipocambio.Tables[0].Rows[0].ItemArray[2].ToString());
            Console.ReadLine();
        }
    }
}
