using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Entidades
{
    [Serializable]
    public class CD : Disco
    {
        #region Constructores
        public CD() { }
        public CD(string titulo, EGenero genero, int año, string nombreArtista, ETipoArtista tipo, float precio)
            : this(titulo, genero, año, new Artista(nombreArtista, tipo), precio)
        {

        }

        public CD(string titulo, EGenero genero, int año, Artista artista, float precio) : base(titulo, genero, año, artista, precio)
        {
        }

        #endregion

        #region sobrecargas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CD -");
            sb.Append((string)(Disco)this);

            return sb.ToString();
        }

        public static bool operator ==(CD b1, CD b2)
        {
            return (Disco)b1 == (Disco)b2;
        }

        public static bool operator !=(CD b1, CD b2)
        {
            return !(b1 == b2);
        }

        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is CD)
            {
                rta = ((CD)obj == this);
            }
            return rta;
        }
        #endregion
    }
}
