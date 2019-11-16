using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NumberConversion.com.dataaccess.www;

namespace NumberConversion
{
    class Program
    {
        #region Variables
        private const string URL = "http://www.dataaccess.com/webservicesserver/numberconversion.wso?WSDL";
        private static string opcion;
        private static int menu;
        #endregion

        static void Main(string[] args)
        {
            if (CheckConnection(URL))
            {
                ulong numero;   //Tipo de dato que admite el servicio.
                com.dataaccess.www.NumberConversion service = new com.dataaccess.www.NumberConversion();
                Console.WriteLine("¡Bienvenid@!\nEste programa convierte la cantidad expresada en numeros a palabras. (En ingles)");
                do
                {
                    Console.WriteLine("Para continuar presiona cualquier tecla, y si desea salir presiona la tecla N.");
                    opcion = Console.ReadLine();
                    if (opcion.Equals("N") || opcion.Equals("n"))   //En caso de que desee salir de la app.
                        break;
                    Console.Clear();                                //Limpiar la consola.

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Menu\n1- Numero a palabras.\n2- Numero a dolares.\n3- Salir");
                        try
                        {
                            menu = int.Parse(Console.ReadLine().ToString());
                            //Numero a palabras:
                            if (menu == 1)
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("Introduce un numero a convertir (El numero debe ser positivo y sin decimal): ");
                                    numero = ulong.Parse(Console.ReadLine().ToString());//Convertir el dato de string a ulong.
                                    var data = service.NumberToWords(numero);           //Llamar el servicio.
                                    Console.WriteLine(data.ToString());                 //Muestra el dato recibido.
                                    Console.ReadKey();
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Error al realizar la conversión.");
                                    throw;
                                }
                            }
                            //Numero a dolares.
                            else if (menu == 2)
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("Introduce la cantidad a convertir (La cantidad debe ser positivo y sin decimal): ");
                                    numero = ulong.Parse(Console.ReadLine().ToString());//Convertir el dato de string a ulong.
                                    var data = service.NumberToDollars(numero);         //Llamar el servicio.
                                    Console.WriteLine(data.ToString());                 //Muestra el dato recibido.
                                    Console.ReadKey();
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Error al realizar la conversión.");
                                    throw;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }

                    } while (true);
                } while (true);
            }
            else
            {
                Console.WriteLine("¡Error! No hay conexion a internet.");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Valida que exista conexion a internet.
        /// </summary>
        /// <param name="URL">Dirrección web</param>
        /// <returns>Retornara un valor verdadero en caso de que exista conexion a la red.</returns>
        private static bool CheckConnection(string URL)
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
    }
}
