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
        /// <summary>
        /// Operacion que devuelve el resultado de una suma.
        /// </summary>
        /// <param name="num1">Primer numero.</param>
        /// <param name="num2">Segundo numero.</param>
        /// <returns>Retorna el resultado de la operación de suma.</returns>
        [OperationContract]
        int GetSuma(int num1, int num2);

        /// <summary>
        /// Operacion que devuelve el resultado de una resta.
        /// </summary>
        /// <param name="num1">Primer numero.</param>
        /// <param name="num2">Segundo numero.</param>
        /// <returns>Retorna el resultado de la operación de resta.</returns>
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

        /// <summary>
        /// Se retorna un saludo junto al nombre brindado por el usuario.
        /// </summary>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <returns>Retorna un mensaje de bienvenida junto al nombre del usuario.</returns>
        [OperationContract]
        string Saludar(string nombre);

        /// <summary>
        /// Valida que exista el usuario.
        /// </summary>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <param name="clave">Clave del usuario.</param>
        /// <returns>Retorna un valor verdadero en caso de que sean validas las credenciales ingresadas.</returns>
        [OperationContract]
        bool Login(string usuario, string clave);

        /// <summary>
        /// Operacion que realiza una multiplicacion.
        /// </summary>
        /// <param name="num1">Primer numero.</param>
        /// <param name="num2">Segundo numero.</param>
        /// <returns>Retorna el resultado de una division.</returns>
        [OperationContract]
        double GetDivide(int num1, int num2);

        /// <summary>
        /// Para la prueba del metodo Salario().
        /// </summary>
        /// <returns>Retorna el resultado brindado por Salario().</returns>
        [OperationContract]
        decimal TestSalario();

        /// <summary>
        /// Metodo que calcula el salario neto de un empleado.
        /// </summary>
        /// <param name="horasTrabajadas">Horas que trabajo el empleado.</param>
        /// <param name="precioPorHora">Precio de las horas del empleado.</param>
        /// <param name="rebajos">Arreglo de datos que contiene un maximo de 3 rebajos.</param>
        /// <returns>Retorna el salario neto de un empleado.</returns>
        [OperationContract]
        decimal Salario(int horasTrabajadas, decimal precioPorHora, decimal[] rebajos);
    }
}
