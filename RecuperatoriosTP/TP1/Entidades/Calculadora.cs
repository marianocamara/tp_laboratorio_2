using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// valida que parametro sea operador (+,-,*,/)
        /// </summary>
        /// <param name="operador">operador a validar</param>
        /// <returns>operador validad - error +</returns>
        private static string ValidarOperador(string operador){
            string retorno = "+";
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                retorno = operador;
            }
            return retorno;
        }

        /// <summary>
        /// realiza una operacion matematica entre dos numeros(+,-,*,/)
        /// </summary>
        /// <param name="n1">obeto1 Numero</param>
        /// <param name="n2">objeto2 Numero</param>
        /// <param name="operador">operador</param>
        /// <returns>double resultado operacion</returns>
        public static double Operar(Numero n1, Numero n2, string operador)
        {
            double retornoResultado = 0;

            switch (ValidarOperador(operador))
            {
                case "+":
                    retornoResultado = n1 + n2;
                    break;
                case "-":
                    retornoResultado = n1 - n2;
                    break;
                case "*":
                    retornoResultado = n1 * n2;
                    break;
                case "/":
                    retornoResultado = n1 / n2;
                    break;
            }

            return retornoResultado;
        }
    }
}
