using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class PrecioInvalidoException : Exception
    {
        static string Mensaje = "El precio ingresado es invalido";
        public PrecioInvalidoException() : base(Mensaje)
        {
        }

        public PrecioInvalidoException(string mensaje) : base(mensaje)
        {
        }

        public PrecioInvalidoException(Exception innerException) : this(string.Empty, innerException)
        {
        }

        public PrecioInvalidoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
        }
    }
}
