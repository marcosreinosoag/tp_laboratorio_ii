﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Validaciones
    {
        /// <summary>
        /// Analiza si un string esta compuesto solamente por letras
        /// </summary>
        /// <param name="cadenaParaAnalizar"></param>
        /// <returns>Retorna la cadena si se verifica que el string fue ingresado correctamente, caso contrario null</returns>
        public static string ValidarString(string cadenaParaAnalizar)
        {
            string retorno = null;
            if (string.IsNullOrWhiteSpace(cadenaParaAnalizar) == true)
            {
                return retorno;
            }
            retorno = cadenaParaAnalizar;
            return retorno;
        }
        /// <summary>
        /// Analiza si un string esta compuesto solamente por letras
        /// </summary>
        /// <param name="cadenaParaAnalizar"></param>
        /// <returns>Retorna la cadena si se verifica que el string fue ingresado correctamente, caso contrario null</returns>
        public static string ValidarStringSoloLetras(string cadenaParaAnalizar)
        {
            string retorno = null;
            if (string.IsNullOrWhiteSpace(cadenaParaAnalizar) == true)
            {
                return retorno;
            }
            foreach (char item in cadenaParaAnalizar)
            {

                if (item < 65 || item > 90)
                {
                    if (item < 97 || item > 122)
                    {
                        return retorno;
                    }
                }
            }
            retorno = cadenaParaAnalizar;
            return retorno;
        }
        /// <summary>
        /// Analiza si un string esta compuesto de numeros y verifica si esta entre el minimo indicado
        /// </summary>
        /// <param name="cadenaParaAnalizar"></param>
        /// <param name="minimo"></param>
        /// <returns>Retorna la cadena si se verifica que el string fue ingresado correctamente, caso contrario null </returns>

        public static string ValidarStringSoloNumeros(string cadenaParaAnalizar, int minimo)
        {
            string retorno = null;
            long numero;
            if (string.IsNullOrWhiteSpace(cadenaParaAnalizar) == true || long.TryParse(cadenaParaAnalizar, out numero) == false || numero < minimo)
            {
                return retorno;
            }
            retorno = cadenaParaAnalizar;
            return retorno;
        }
        /// <summary>
        /// Analiza si un string esta compuesto de numeros y verifica si esta entre el minimo y maximo indicado
        /// </summary>
        /// <param name="cadenaParaAnalizar"></param>
        /// <param name="minimo"></param>
        /// <param name="maximo"></param>
        /// <returns>Retorna la cadena si se verifica que el string fue ingresado correctamente, caso contrario null </returns>
        public static string ValidarStringSoloNumeros(string cadenaParaAnalizar, int minimo, int maximo)
        {
            string retorno = null;
            int numero;
            if (string.IsNullOrWhiteSpace(cadenaParaAnalizar) == true)
            {
                return retorno;
            }
            if (int.TryParse(cadenaParaAnalizar, out numero) == false)
            {
                return retorno;
            }
            if (numero < minimo)
            {
                return retorno;
            }
            if (numero > maximo)
            {
                return retorno;
            }
            retorno = cadenaParaAnalizar;
            return retorno;
        }
        /// <summary>
        /// Analiza si un string esta compuesto de numeros decimales y verifica si esta entre el minimo indicado
        /// </summary>
        /// <param name="cadenaParaAnalizar"></param>
        /// <param name="minimo"></param>
        /// <param name="maximo"></param>
        /// <returns>Retorna la cadena si se verifica que el string fue ingresado correctamente, caso contrario null </returns>

        public static string ValidarStringSoloNumerosConComa(string cadenaParaAnalizar, int minimo)
        {
            string retorno = null;
            decimal numero;
            if (string.IsNullOrWhiteSpace(cadenaParaAnalizar) == true)
            {
                return retorno;
            }
            if (decimal.TryParse(cadenaParaAnalizar, out numero) == false)
            {
                return retorno;
            }
            if (numero < minimo)
            {
                return retorno;
            }
            retorno = cadenaParaAnalizar;
            return retorno;
        }
        public static int ConvertirStringAEntero(this string stringAConvertir)
        {
            int retorno = -1;
            if (int.TryParse(stringAConvertir, out retorno))
            {
                return retorno;
            }
            return retorno;
        } 
        public static decimal ConvertirStringADecimal(this string stringAConvertir)
        {
            decimal retorno = -1;
            if (decimal.TryParse(stringAConvertir, out retorno))
            {
                return retorno;
            }
            return retorno;
        }
    }
}
