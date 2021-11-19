using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public static class ExtensionDisco
    {
        /// <summary>
        /// Valida que el precio sea mayor que 0
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        public static float ValidarPrecio(this Disco d, float precio)
        {
            if (precio <= 0)
            {
                throw new PrecioInvalidoException();
            }
            return precio;
        }


        /// <summary>
        /// Valida que el año sea correcto
        /// </summary>
        /// <param name="año"></param>
        /// <returns></returns>
        public static int ValidarAño(this Disco d ,int año)
        {
            if (año < 1900 || año > 2022)
            {
                throw new AñoInvalidoException();
            }
            return año;
        }
    }
}
