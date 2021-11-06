using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Serializador<T> : IArchivo<T> where T : class
    {
        private XmlTextWriter xmlTextWriter;
        private XmlTextReader xmlTextReader;
        private XmlSerializer xmlSerializer;

        public bool Guardar(string path, T datos)
        {
            bool sePudoGuadar = false;
            try
            {

                if (datos != null && Path.GetExtension(path) == ".xml")
                {

                    using (xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8))
                    {
                        xmlTextWriter.Formatting = Formatting.Indented;
                        xmlSerializer = new XmlSerializer(typeof(T));
                        xmlSerializer.Serialize(xmlTextWriter, datos);
                        sePudoGuadar = true;
                    }
                }
                else 
                { throw new ErrorArchivoException(); }

                return sePudoGuadar;

            }
            catch (Exception)
            {
                throw new ErrorArchivoException();
            }
        }

        public bool Leer(string archivos, out T datos)
        {
            bool retorno = false;
            datos = default;
            try
            {
                if (File.Exists(archivos))
                {
                    using (xmlTextReader = new XmlTextReader(archivos))
                    {
                        xmlSerializer = new XmlSerializer(typeof(T));
                        if (xmlSerializer.CanDeserialize(xmlTextReader))
                        {
                            datos = (T)xmlSerializer.Deserialize(xmlTextReader);
                            retorno = true;
                        }
                    }
                }
                else
                {
                    throw new ErrorArchivoException("No existe el archivo");
                }
                return retorno;

            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e);
            }
        }
    }
}
