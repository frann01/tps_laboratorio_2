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

        private bool EsBinario(string binario)
        {
            bool retorno = true;

            foreach (var item in binario)
            {
                if(item != '1' && item != '0') 
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        public string decimalBinario(double numero) 
        {
            return decimalBinario(numero.ToString());
        }
        public string decimalBinario(string numeroStr)
        {
            double binario = 0;
            double numero = double.Parse(numeroStr);
            const double DIVISOR = 2;
            double digito = 0;

            for (double i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                binario += digito * (double)Math.Pow(10, j);
            }

            numeroStr = binario.ToString();

            if (!EsBinario(numeroStr))
            {
                numeroStr = "Valor invalido";
            }

            return numeroStr;
        }
        public string binarioDecimal(string numeroStr)
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
