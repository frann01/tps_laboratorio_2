using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public static class ExtensionTienda
    {
        public static bool GuardarGanacia(this Tienda<Disco> t)
        {
            bool sePudoGuadar = false;
            StreamWriter streamWriter;
            try
            {
                if (t != null)
                {
                    using (streamWriter = new StreamWriter("ganaciaTienda.txt", false, Encoding.UTF8))
                    {
                        streamWriter.WriteLine(t.Ganacia);
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

        public static bool CargarGanacia(this Tienda<Disco> t)
        {
            bool sePudoLeer = false;
            StreamReader streamReader;

            try
            {
                if (File.Exists("ganaciaTienda.txt"))
                {
                    using (streamReader = new StreamReader("ganaciaTienda.txt"))
                    {
                        t.Ganacia = float.Parse(streamReader.ReadToEnd());
                        sePudoLeer = true;
                    }
                }
                else
                {
                    throw new ErrorArchivoException();
                }
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException(ex);
            }
            return sePudoLeer;
        }
    }
}
