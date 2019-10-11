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
        /// <summary>
        /// Metodo que llama al servicio web para hacer la consulta de los indicadores economicos.
        /// </summary>
        /// <param name="indicador">Numero de identificador economico.</param>
        /// <param name="fecha">Fecha que se desea validar</param>
        /// <param name="usuario">Nombre del usuario</param>
        /// <returns>Retorna una lista con todos los datos devueltos por el servicio.</returns>
        public List<string> ConsultaIndicador(string indicador, string fecha, string usuario)
        {
            List<string> datos = new List<string>();
            cr.fi.bccr.gee.wsIndicadoresEconomicos cliente = new cr.fi.bccr.gee.wsIndicadoresEconomicos();
            DataSet Tipocambio = cliente.ObtenerIndicadoresEconomicos(indicador, fecha, fecha, usuario, "N");
            datos.Add(Tipocambio.Tables[0].Rows[0].ItemArray[0].ToString());    //Codigo identificador.
            datos.Add(Tipocambio.Tables[0].Rows[0].ItemArray[1].ToString());    //Fecha Consuta.
            datos.Add(Tipocambio.Tables[0].Rows[0].ItemArray[2].ToString());    //Valor.
            return datos;
        }
    }
}
