using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorArchivoException : Exception
    {
        static string Mensaje = "Hubo un error con el archivo!";
        public ErrorArchivoException() : base(Mensaje)
        {
        }

        public ErrorArchivoException(string mensaje) : base(mensaje)
        {
        }

        public ErrorArchivoException(Exception innerException) : this(string.Empty, innerException)
        {
        }

        public ErrorArchivoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
        }
    }
}
