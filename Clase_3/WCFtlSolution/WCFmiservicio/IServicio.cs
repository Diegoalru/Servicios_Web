using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFmiservicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicio" in both code and config file together.
    [ServiceContract]
    public interface IServicio
    {
        [OperationContract]
        int GetSuma(int num1, int num2);

        [OperationContract]
        int GetResta(int num1, int num2);

        /// <summary>
        /// Operacion que devuelve el resultado de una división.
        /// </summary>
        /// <param name="num1">Primer numero.</param>
        /// <param name="num2">Segundo numero.</param>
        /// <returns>Retorna el resultado de la operación de division.</returns>
        [OperationContract]
        double GetDivision(int num1, int num2);

        /// <summary>
        /// Operacion que devuelve el resultado de una multiplicación.
        /// </summary>
        /// <param name="num1">Primer numero.</param>
        /// <param name="num2">Segundo numero.</param>
        /// <returns>Retorna el resultado de la operación de multiplicación.</returns>
        [OperationContract]
        int GetMultiplicacion(int num1, int num2);

        /// <summary>
        /// Operacion que devuelve el modulo de una división.
        /// </summary>
        /// <param name="num1">Primer numero.</param>
        /// <param name="num2">Segundo numero.</param>
        /// <returns>Retorna el resultado de la operación de modulo.</returns>
        [OperationContract]
        int GetModulo(int num1, int num2);

        [OperationContract]
        string Saludar(string nombre);

        [OperationContract]
        bool Login(string usuario, string clave);

        [OperationContract]
        double GetDivide(int num1, int num2);
    }
}
