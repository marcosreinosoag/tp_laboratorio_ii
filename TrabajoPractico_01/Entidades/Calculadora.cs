using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Recibe dos numero y el tipo de operacion que se requiere realizar y retorna el resultado.
        /// </summary>
        /// <param name="num1">Variable num1, contiene el primer numero ingresado</param>
        /// <param name="num2">Variable num2, contiene el segundo numero ingresado</param>
        /// <param name="operador">Variable operador contiene el operador de la cuenta que se va a realizar</param>
        /// <returns>Retorna el resultado de la cuenta realizada</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char opcionOperador = ValidarOperador(operador);
            switch (opcionOperador)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
            }
            return num1 + num2; 
        }

        /// <summary>
        /// Valida que el operador sea: +, -, / o *
        /// </summary>
        /// <param name="operador">Variable operador, contiene el operador de la cuenta que se va a realizar.</param>
        /// <returns>Retorna el operador.</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }

    }
}
