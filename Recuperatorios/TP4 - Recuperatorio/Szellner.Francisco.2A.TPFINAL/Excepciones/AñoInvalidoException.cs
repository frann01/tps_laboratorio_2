using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AñoInvalidoException: Exception
    {
        static string Mensaje = "El año ingresado es invalido";
        public AñoInvalidoException() : base(Mensaje)
        {
        }

        public AñoInvalidoException(string mensaje) : base(mensaje)
        {
        }

        public AñoInvalidoException(Exception innerException) : this(string.Empty, innerException)
        {
        }

        public AñoInvalidoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
        }
    }
}
