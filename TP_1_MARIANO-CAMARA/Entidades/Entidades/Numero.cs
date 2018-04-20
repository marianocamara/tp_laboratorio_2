using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        
        private double numero;

        /// <summary>
        /// valida que el parametro entregado es numerico
        /// </summary>
        /// <param name="strNumero"> cadena a validar</param>
        /// <returns>double numerico ok - error 0</returns>
        private double ValidarNumero(string strNumero) {
            double retorno = 0;
            double numero;

            if (Double.TryParse(strNumero, out numero)) {
                retorno = numero;
            }
            return retorno;
        }

        #region Set

        public Numero(double numero) {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        
        public string SetNumero
        {
            set
            {
                double n = ValidarNumero(value);
                if ( n != 0) 
                    this.numero = n;
            }
        }

        #endregion

        #region Binary-Decimal

        /// <summary>
        /// convierte string binario a numero entero
        /// </summary>
        /// <param name="binario">cadena con numero binario</param>
        /// <returns>string numero convertido - error valor invalido</returns>
        public static string BinarioDecimal(string binario) {
            string retorno = "Valor Invalido";
            int convertido;

            bool esBinario = true;
            foreach (char c in binario)
            {
                if (c != '0' && c != '1')
                {
                    esBinario = false;
                    break;
                }
            }

            if (esBinario) {
                if ((int.TryParse(binario, out convertido)))
                {
                    retorno = Convert.ToInt32(binario, 2).ToString();
                }
            }
            
            
            return retorno;
        }

        /// <summary>
        /// convierte double decimal a string binario
        /// </summary>
        /// <param name="numero">double numero a convertir</param>
        /// <returns>string binario - error valor invalido</returns>
        public static string DecimalBinario(double numero){
            string retorno = "Valor Invalido";

            if (!(Double.IsNaN(numero)))
            {
                long n = Convert.ToInt64(numero);
                retorno = Convert.ToString(n, 2); 
            }
            return retorno;
        }

        /// <summary>
        /// convierte string decimal a string binario
        /// </summary>
        /// <param name="strNumero">string numero a convertir</param>
        /// <returns>string binario - error valor invalido</returns>
        public static string DecimalBinario(string strNumero)
        {
            double convertido;
            string retorno = "Valor Invalido";

            if ((double.TryParse(strNumero, out convertido)))
            {
                retorno = Convert.ToString((int)convertido, 2);              
            }
            return retorno;
        }
        
        #endregion

        #region Operaciones

        /// <summary>
        /// sobrecarga del operador +
        /// </summary>
        /// <param name="n1">objeto1 Numero</param>
        /// <param name="n2">objeto2 Numero</param>
        /// <returns>suma de objetos Numero</returns>
        public static double operator +(Numero n1, Numero n2) {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// sobrecarga del operador -
        /// </summary>
        /// <param name="n1">objeto1 Numero</param>
        /// <param name="n2">objeto2 Numero</param>
        /// <returns>resta de objetos Numero</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// sobrecarga del operador *
        /// </summary>
        /// <param name="n1">objeto1 Numero</param>
        /// <param name="n2">objeto2 Numero</param>
        /// <returns>multiplicacion de objetos Numero</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// sobrecarga del operador /
        /// </summary>
        /// <param name="n1">objeto1 Numero</param>
        /// <param name="n2">objeto2 Numero</param>
        /// <returns>division de objetos Numero</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }
        #endregion
    }
}
