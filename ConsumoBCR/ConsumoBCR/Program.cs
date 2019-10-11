using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConsumoBCR.Logic;
using System.Net;

namespace ConsumoBCR
{
    class Program
    {
        #region Variables
        public static string Nombre { get; set; }
        private static string URL = "http://indicadoreseconomicos.bccr.fi.cr/indicadoreseconomicos/WebServices/wsIndicadoresEconomicos.asmx";
        private static bool NombreValido = false;
        #endregion

        static void Main(string[] args)
        {
            //Url para verificar la conexion a internet.
            if (CheckConnection(URL))
            {
                //Solicitar el nombre y validarlo
                int Intento = 0;
                Console.WriteLine("¡Bienvenid@!");
                do
                {
                    Intento++;
                    if (Intento >= 2)
                        Console.WriteLine("¡Nombre incorrecto!");
                    SolicitaNombre();
                } while (!NombreValido);

                Consulta c = new Consulta();
                int opcion;
                List<string> datosDolar;
                List<string> datosEuros;
                float dolares, euros, resultado; //Estas variables solo se usan para los resultados de los euros.
                do
                {
                    opcion = DisplayMenu();
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Venta Dolar");
                            datosDolar = c.ConsultaIndicador("317", GetFechaActual(), Nombre);
                            Console.WriteLine("Codigo Identificador: " + datosDolar[0] + "\n" +
                                               "Fecha Consultada: " + datosDolar[1] + "\n" +
                                               "Valor: " + datosDolar[2] + "\n");
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Compra Dolar");
                            datosDolar = c.ConsultaIndicador("318", GetFechaActual(), Nombre);
                            Console.WriteLine("Codigo Identificador: " + datosDolar[0] + "\n" +
                                               "Fecha Consultada: " + datosDolar[1] + "\n" +
                                               "Valor: " + datosDolar[2] + "\n");

                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Compra Euro");
                            datosDolar = c.ConsultaIndicador("317", GetFechaActual(), Nombre);
                            datosEuros = c.ConsultaIndicador("333", GetFechaActual(), Nombre);

                            dolares = float.Parse(datosDolar[2].ToString());
                            euros = float.Parse(datosEuros[2].ToString());
                            resultado = dolares * euros;

                            Console.WriteLine("Codigo Identificador: " + datosEuros[0] + "\n" +
                                               "Fecha Consultada: " + datosEuros[1] + "\n" +
                                               "Valor: " + resultado.ToString() + "\n");
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Compra Euro");
                            datosDolar = c.ConsultaIndicador("318", GetFechaActual(), Nombre);
                            datosEuros = c.ConsultaIndicador("333", GetFechaActual(), Nombre);

                            dolares = float.Parse(datosDolar[2].ToString());
                            euros = float.Parse(datosEuros[2].ToString());
                            resultado = dolares * euros;

                            Console.WriteLine("Codigo Identificador: " + datosEuros[0] + "\n" +
                                               "Fecha Consultada: " + datosEuros[1] + "\n" +
                                               "Valor: " + resultado.ToString() + "\n");
                            break;
                        default:
                            break;
                    }
                } while (opcion != 5);
            }
            else
            {
                Console.WriteLine("¡Error! No se puede conectar con el servidor.");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Menú de opciones que tendrá el programa.
        /// </summary>
        /// <returns>La opcion dada por el usuario.</returns>
        private static int DisplayMenu()
        {
            Console.Write(@"
                            SELECCIONE UNA OPCION DE LA LISTA
                              ----------------------------------
                              1. Consultar tipo cambio de venta del Dolar.
                              2. Consultar tipo cambio de compra del Dolar.
                              3. Consultar tipo cambio de venta del Euro.
                              4. Consultar tipo cambio de compra del Euro.
                              5. Salir.
                              ----------------------------------
                                  ");
            int.TryParse(Console.ReadLine(), out int result);
            return result;
        }

        #region Validadores
        /// <summary>
        /// Solicita al usuario el nombre que será enviado al Servicio Web.
        /// </summary>
        private static void SolicitaNombre()
        {
            Console.Write(@"Ingrese su nombre completo: ");
            Nombre = Console.ReadLine().ToString();
            if (Valida(Nombre))
                NombreValido = true;
        }

        /// <summary>
        /// Valida que el Nombre del usuario no esté vacio.
        /// </summary>
        /// <param name="dato">Nombre del usuario.</param>
        /// <returns>Retornara un valor verdadero en caso de que el dato tenga información.</returns>
        private static bool Valida(string dato)
        {
            if (dato.Equals("") || dato == null || dato.Length <= 2)
                return false;
            return true;

        }

        /// <summary>
        /// Devuelve la fecha actual de la maquina.
        /// </summary>
        /// <returns>Retorna la fecha actual.</returns>
        private static string GetFechaActual()
        {
            return string.Format(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
        }

        /// <summary>
        /// Valida que exista conexion a internet.
        /// </summary>
        /// <param name="URL">Dirrección web</param>
        /// <returns>Retornara un valor verdadero en caso de que exista conexion a la red.</returns>
        private static bool CheckConnection(String URL)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Timeout = 5000;
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
