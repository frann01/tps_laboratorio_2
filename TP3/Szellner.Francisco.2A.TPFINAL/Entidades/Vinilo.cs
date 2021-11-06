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
    public class Vinilo : Disco
    {
        protected int id_vinilo;
        protected ETipoVinilo condicion;

        #region Constructores

        private Vinilo() { }

        public Vinilo(string titulo, EGenero genero, int año, string nombreArtista, ETipoArtista tipo, ETipoVinilo cond, float precio)
            : this(titulo, genero, año, new Artista(nombreArtista, tipo), cond, precio) 
        {

        }

        public Vinilo(string titulo, EGenero genero, int año, Artista artista, ETipoVinilo cond, float precio) :base(titulo, genero, año, artista, precio)
        {
            this.condicion = cond;
        }

        #endregion

        #region setters y getters

        public ETipoVinilo Condicion 
        {
            set 
            {
                this.condicion = value;
            }
            get { return this.condicion; }
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Muestra los datos del dico
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Vinilo -");
            sb.Append((string)(Disco) this);
            sb.AppendLine("Condicion: " + this.condicion);

            return sb.ToString();
        }


        /// <summary>
        /// COmpara dos vinilos como disco y si tienen la misma condicion
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        public static bool operator ==(Vinilo b1, Vinilo b2)
        {
            bool rta = false;

            if (((object)b1) == null && ((object)b2) == null)
            {
                rta = true;
            }
            else
            {
                if (((object)b1) != null && ((object)b2) != null)
                {
                    if ((Disco)b1 == (Disco)b2 && b1.condicion == b2.condicion)
                    {
                        rta = true;
                    }
                }
            }

            return rta;
        }

        public static bool operator !=(Vinilo b1, Vinilo b2)
        {
            return !(b1 == b2);
        }

        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Vinilo)
            {
                rta = ((Vinilo)obj == this);
            }
            return rta;
        }

        #endregion
    }
}
