using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConsumoBCR.Logic;

namespace ConsumoBCR
{
    class Program
    {
        static void Main(string[] args)
        {

            Consulta c = new Consulta();
            int opcion;
            do
            {
                opcion = DisplayMenu();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Caso 1");
                        Console.WriteLine("Valor = " + c.ConsultaIndicador("317"));
                        break;
                    case 2:
                        Console.WriteLine("Caso 2");
                        Console.WriteLine("Valor = " + c.ConsultaIndicador("318"));
                        break;
                    case 3:
                        Console.WriteLine("Caso 3");
                        Console.WriteLine("Valor = " + (c.ConsultaIndicador("333")/* c.ConsultaIndicador("317")*/)); 
                        break;
                    case 4:
                        Console.WriteLine("Caso 4");
                        break;
                    default:
                        break;

                }
            } while (opcion != 5);
        }

        private static int DisplayMenu()
        {
            Console.Write(@"
                            SELECCIONE UNA OPCION DE LA LISTA
                              ----------------------------------
                              1. Consultar tipo cambio de venta del Dolar.
                              2. Consultar tipo cambio de venta del Euro.
                              3. Consultar tipo cambio de compra del Dolar.
                              4. Consultar tipo cambio de compra del Euro.
                              5. Salir.
                              ----------------------------------
                                  ");
            int.TryParse(Console.ReadLine(), out int result);
            return result;
        }
    }
}
