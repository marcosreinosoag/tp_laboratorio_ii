using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando() : this(0)
        {

        }
        public Operando(double numero) : this(numero.ToString())
        {
            this.numero = numero;
        }
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }
        /// <summary>
        /// Valida y setea el valor recibido
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value.ToString());
            }
        }
        /// <summary>
        /// Valida y convierte un numero binario a decimal.
        /// </summary>
        /// <param name="binario">Numero binario</param>
        /// <returns>Retorna el numero decimal</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";
            int i;
            int a = binario.Length;
            int acumulador = 0;
            if (!string.IsNullOrEmpty(binario) && EsBinario(binario))
            {
                for (i = 0; i < binario.Length; i++)
                {
                    a--;
                    if (binario[a] == '0')
                    {
                        continue;
                    }
                    else if (binario[a] == '1')
                    {
                        acumulador += (int)Math.Pow(1 * 2, i);
                    }
                }
                retorno = acumulador.ToString();
            }
            return retorno;
        }
        /// <summary>
        /// Valida y convierte un numero decimal y a binario.
        /// </summary>
        /// <param name="numero">Numero decimal que se recibe</param>
        /// <returns>Retorna el numero binario</returns>
        public string DecimalBinario(double numero)
        {
            int numeroRecibido = (int)Math.Round(numero);
            string numeroBinario = "";
            string retorno = "Valor invalido";
            if (numeroRecibido > 0)
            {
                do
                {
                    if (numeroRecibido % 2 == 0)
                    {
                        numeroBinario = "0" + numeroBinario;
                    }
                    else
                    {
                        numeroBinario = "1" + numeroBinario;
                    }
                    numeroRecibido = numeroRecibido / 2;
                } while (numeroRecibido > 0);
                retorno = numeroBinario;
                return retorno;
            }
            else if (numeroRecibido == 0)
            {
                retorno = "0";
            }
            return retorno;
        }
        /// <summary>
        ///  Valida y convierte un numero decimal a binario.
        /// </summary>
        /// <param name="numero">Numero decimal que se recibe</param>
        /// <returns>Retorna el numero binario</returns>
        public string DecimalBinario(string numero)
        {
            double numeroDouble = Convert.ToDouble(numero);
            return DecimalBinario(numeroDouble);
        }

        /// <summary>
        /// Valida que numero ingresado contenga 0 y 1.
        /// </summary>
        /// <param name="binario">Numero binario recibido.</param>
        /// <returns>Retorna true en caso del que el numero sea binario y false en caso contrario.</returns>
        private bool EsBinario(string binario)
        {
            bool retorno = false;
            if (!string.IsNullOrEmpty(binario))
            {
                retorno = true;
                for (int i = 0; i < binario.Length; i++)
                {
                    if (binario[i] != '0' && binario[i] != '1')
                    {
                        retorno = false;
                        break;
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// Realiza la suma de dos valores de clase Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Devuelve el resultado de la suma.</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Realiza la resta de dos valores de clase Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Devuelve el resultado de la resta</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Realiza la multiplicacion de dos valores de clase Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Devuelve el resultado de la multiplicacion</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Realiza la division de dos valores de clase Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el resultado de la division. Si el segundo operando es igual a 0 retorna double.MinValue</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double retorno = double.MinValue;
            if (n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
                return retorno;
            }
            return retorno;
        }

        /// <summary>
        /// Comprueba que el valor recibido sea numerico.
        /// </summary>
        /// <param name="strNumero">Valor que se verifica </param>
        /// <returns>Retorna el valor recibido en formato Double.Caso contrario retorna 0</returns>

        private double ValidarOperando(string strNumero)
        {
            if (!string.IsNullOrEmpty(strNumero))
            {
                double numero;
                string auxstrNumero;
                auxstrNumero = strNumero.Replace('.', ',');

                if (double.TryParse(auxstrNumero, out numero))
                {
                    return numero;
                }
            }
            return 0;
        }

    }
}
