using System;

namespace Entidades
{
    public class Calculadora
    {
        private static char  validarOperando(char operador) 
        {
            char retorno = '+';

            if(operador == '-' || operador == '*' || operador == '/') 
            {
                retorno = operador;
            }

            return retorno;
        }

        public double Operar(Operando num1, Operando num2, char operador) 
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
