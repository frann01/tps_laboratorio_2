using System;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Valida que el caracter dado pertenezca a {+,-,*,/}
        /// </summary>
        /// <param name="operador"></param>
        /// <returns> + en caso de pertenecer o el caracter en si si pertenece</returns>
        private static char  validarOperando(char operador) 
        {
            char retorno = '+';

            if(operador == '-' || operador == '*' || operador == '/') 
            {
                retorno = operador;
            }

            return retorno;
        }

        /// <summary>
        /// realiza una operacion segun el operador dado
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns> retorna el resultado</returns>
        public static double Operar(Operando num1, Operando num2, char operador) 
        {
            char simbolo = validarOperando(operador);
            double resultado=0;

            switch (operador) 
            {
                case '+':
                    resultado = num1 + num2;
                    break;

                case '-':
                    resultado = num1 - num2;
                    break;

                case '/':
                    if(num2.Numero == "0") 
                    {
                        resultado = double.MinValue;
                    }
                    else 
                    {
                        resultado = num1 / num2;
                    }
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;
            }

            return resultado;
        }
    }

}
