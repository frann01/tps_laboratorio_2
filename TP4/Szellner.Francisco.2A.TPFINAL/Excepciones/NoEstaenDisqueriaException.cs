using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoEstaenDisqueriaException : Exception
    {
        static string Mensaje = "El disco no se encuentra en la disqueria";
        public NoEstaenDisqueriaException() : base(Mensaje)
        {
        }

        public NoEstaenDisqueriaException(string mensaje) : base(mensaje)
        {
        }

        public NoEstaenDisqueriaException(Exception innerException) : this(string.Empty, innerException)
        {
        }

        public NoEstaenDisqueriaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
        }
    }
}
