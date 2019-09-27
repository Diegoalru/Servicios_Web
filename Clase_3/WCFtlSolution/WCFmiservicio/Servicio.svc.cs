using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFmiservicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Servicio" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Servicio.svc or Servicio.svc.cs at the Solution Explorer and start debugging.
    public class Servicio : IServicio
    {
        public int GetSuma(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
    }
}
