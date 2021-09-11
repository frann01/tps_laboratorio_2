using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando() 
        {
            this.numero = 0;
        }
        public Operando(double entero)
        {
            this.Numero = entero.ToString();
        }
        public Operando(string entero)
        {
            this.Numero = entero;
        }

        
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
        
        private double ValidarOperando(string numberStr) 
        {
            double retorno;

            if (double.TryParse(numberStr, out retorno)==false) 
            {
                retorno = 0;
            }

            return retorno;
        }

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

        public static string decimalBinario(double numero) 
        {
            return decimalBinario(numero.ToString());
        }
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

        public static double operator +(Operando a, Operando b)
        {
            return a.numero + b.numero;
        }
        public static double operator -(Operando a, Operando b)
        {
            return a.numero - b.numero;
        }
        public static double operator /(Operando a, Operando b)
        {
            return a.numero / b.numero;
        }
        public static double operator *(Operando a, Operando b)
        {
            return a.numero * b.numero;
        }
    }
}
