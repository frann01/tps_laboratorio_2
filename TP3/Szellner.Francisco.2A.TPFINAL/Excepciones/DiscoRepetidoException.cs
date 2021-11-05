using System;

namespace Excepciones
{
    public class DiscoRepetidoException : Exception
    {
        static string Mensaje = "El disco ya esta en la disqueria";
        public DiscoRepetidoException() : base(Mensaje)
        {
        }

        public DiscoRepetidoException(string mensaje) : base(mensaje)
        {
        }

        public DiscoRepetidoException(Exception innerException) : this(string.Empty, innerException)
        {
        }

        public DiscoRepetidoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
        }
    }
}
