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
        #region Basicos

        public int GetSuma(int num1, int num2)
        {
            return num1 + num2; ;
        }

        public int GetResta(int num1, int num2)
        {
            return num1 - num2; ;
        }

        public double GetDivision(int num1, int num2)
        {
            return (double)num1 / num2;
        }

        public int GetMultiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        public int GetModulo(int num1, int num2)
        {
            return num1 % num2;
        }

        #endregion

        #region Practica 1

        public string Saludar(string nombre)
        {
            string saludo = "Hola ";
            saludo += nombre;
            return saludo;
        }

        public bool Login(string usuario, string clave)
        {
            //Validaciones:
            if (EsVacio(usuario)) return false;
            if (EsVacio(clave)) return false;

            if (usuario.Equals("Admin") && clave.Equals("987"))
                return true;
            return false;
        }

        #endregion

        #region Practica 2

        private int Indica0(int num)
        {
            return (num == 0) ? -999 : num;
        }

        public double GetDivide(int num1, int num2)
        {
            int divisor = Indica0(num2);
            if (divisor != -999)
            {
                return divisor;
            }
            else
            {
                return GetDivision(num1, num2);
            }
        }

        private bool EsVacio(string texto)
        {
            if (texto.Equals("") || texto == null)
                return true;
            return false;
        }

        #endregion
    }
}
