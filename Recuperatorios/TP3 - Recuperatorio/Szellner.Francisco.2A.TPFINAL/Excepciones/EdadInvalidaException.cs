using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class EdadInvalidaException:Exception
    {
        static string Mensaje = "La edad ingresada es invalida";
        public EdadInvalidaException() : base(Mensaje)
        {
        }

        public EdadInvalidaException(string mensaje) : base(mensaje)
        {
        }

        public EdadInvalidaException(Exception innerException) : this(string.Empty, innerException)
        {
        }

        public EdadInvalidaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
        }
    }
}
