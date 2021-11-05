using System;

namespace Archivos
{
    public interface IArchivo<T>
    {
        bool Guardar(string archivos, T datos);
        bool Leer(string archivos, out T datos);
    }
}
