using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Contructor base
        /// </summary>
        public Operando() 
        {
            this.numero = 0;
        }
        /// <summary>
        /// Constructor con un parametro
        /// </summary>
        /// <param name="entero">Numero a asignar</param>
        public Operando(double entero)
        {
            this.Numero = entero.ToString();
        }
        /// <summary>
        ///  Constructor con un parametro
        /// </summary>
        /// <param name="entero">Numero a asignar</param>
        public Operando(string entero)
        {
            this.Numero = entero;
        }

        /// <summary>
        /// get y set de la clase
        /// </summary>
        public string Numero 
        {
            get 
            {
                return numero.ToString();
            }
            set 
            {
                if (this.ValidarOperando(value.ToString())!=0) 
                {
                    numero = double.Parse(value);
                }
            }
        }
        
        /// <summary>
        /// Valida que el valor ingresado sea un numero
        /// </summary>
        /// <param name="numberStr">valor a validar</param>
        /// <returns>0 en caso de que no sea valido, el numero en caso de serlo</returns>
        private double ValidarOperando(string numberStr) 
        {
            double retorno;

            if (double.TryParse(numberStr, out retorno)==false) 
            {
                retorno = 0;
            }

            return retorno;
        }

        /// <summary>
        /// valida que la cadena ingresada sea un numero binario
        /// </summary>
        /// <param name="binario">cadena a validar</param>
        /// <returns>true en caso de ser binario, false en caso de que no</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;

            if (binario == "")
            {
                retorno = false;
            }
            else
            {
                foreach (var item in binario)
                {
                    if (item != '1' && item != '0')
                    {
                        retorno = false;
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// transforma un double a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string decimalBinario(double numero) 
        {
            return decimalBinario(numero.ToString());
        }

        /// <summary>
        /// trasforma un numero decimal en formato string a un numero binario en formato string
        /// </summary>
        /// <param name="numeroStr"></param>
        /// <returns></returns>
        public static string decimalBinario(string numeroStr)
        {
            long binario = 0;

            double numero = double.Parse(numeroStr);

            long descartable = 0;

            for (double i = numero % 2, j = 0; numero > 0; numero /= 2, i = numero % 2, j++)
            {
                descartable = (long)i % 2;
                binario = binario + descartable * (long)Math.Pow(10, j);
            }

            numeroStr = binario.ToString();
            if (!EsBinario(numeroStr))
            {
                numeroStr = "Valor invalido";
            }

            return numeroStr;
        }

        /// <summary>
        /// transforma un numero binario en decimal
        /// </summary>
        /// <param name="numeroStr"></param>
        /// <returns></returns>
        public static string binarioDecimal(string numeroStr)
        {
            double res=0;
            string retorno;

            if (EsBinario(numeroStr)) 
            {
                for(int x = numeroStr.Length -1, y=0; x >= 0 ; x--, y++) 
                {
                    res += (double)(double.Parse(numeroStr[x].ToString()) * Math.Pow(2, y));
                }
                retorno = res.ToString();
            }
            else 
            {
                retorno = "Valor invalido";
            }

            return retorno;
        }

        /// <summary>
        /// sobreescribe el operador + para sumar la variable numero de dos operandos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator +(Operando a, Operando b)
        {
            return a.numero + b.numero;
        }

        /// <summary>
        /// sobreescribe el operador - para restar la variable numero de dos operandos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator -(Operando a, Operando b)
        {
            return a.numero - b.numero;
        }

        /// <summary>
        /// sobreescribe el operador / para dividir la variable numero de dos operandos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator /(Operando a, Operando b)
        {
            return a.numero / b.numero;
        }

        /// <summary>
        /// sobreescribe el operador * para multiplicar la variable numero de dos operandos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator *(Operando a, Operando b)
        {
            return a.numero * b.numero;
        }
    }
}
