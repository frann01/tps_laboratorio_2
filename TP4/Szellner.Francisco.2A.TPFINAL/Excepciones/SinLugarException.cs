using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinLugarException : Exception
    {
        static string Mensaje = "No hay mas lugar";
        public SinLugarException() : base(Mensaje)
        {
        }

        public SinLugarException(string mensaje) : base(mensaje)
        {
        }

        public SinLugarException(Exception innerException) : this(string.Empty, innerException)
        {
        }

        public SinLugarException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
        }
    }
}
