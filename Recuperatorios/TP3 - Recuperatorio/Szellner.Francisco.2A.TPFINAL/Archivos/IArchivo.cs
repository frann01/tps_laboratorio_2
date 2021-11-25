using System;

namespace Archivos
{
    /// <summary>
    /// Uso de interfaces en clase Serializador y json
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IArchivo<T>
    {
        bool Guardar(string archivos, T datos);
        bool Leer(string archivos, out T datos);
    }
}
