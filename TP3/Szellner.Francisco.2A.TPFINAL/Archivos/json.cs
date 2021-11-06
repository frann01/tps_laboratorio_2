using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    /// <summary>
    /// Uso de interfaces
    /// </summary>
    class json : IArchivo<string>
    {
        private StreamWriter streamWriter;
        private StreamReader streamReader;

        #region Constructor
        public json()
        {

        }
        #endregion

        #region Metodos
        /// <summary>
        /// Guarda el string en un archivo de texto.
        /// </summary>
        /// <param name="archivos"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string path, string datos)
        {
            bool sePudoGuadar = false;
            try
            {
                if (datos != null)
                {
                    using (streamWriter = new StreamWriter(path +".json", false, Encoding.UTF8))
                    {
                        streamWriter.WriteLine(datos);
                        sePudoGuadar = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException(ex);
            }
            return sePudoGuadar;
        }

        /// <summary>
        /// Lee los datos desde un archivo de texto.
        /// </summary>
        /// <param name="archivos"></param>
        /// <param name="datos"></param>
        /// <returns>Devuelve true si lo pudo leer, false en cualquier otro caso.</returns>
        public bool Leer(string archivos, out string datos)
        {
            bool sePudoLeer = false;
            string path = archivos + ".json";
            try
            {
                if (File.Exists(path))
                {
                    using (streamReader = new StreamReader(path))
                    {
                        datos = streamReader.ReadToEnd();
                        sePudoLeer = true;
                    }
                }
                else
                {
                    throw new ErrorArchivoException("No existe el archivo : " + path);
                }
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException(ex);
            }
            return sePudoLeer;
        }
        #endregion
    }
}
