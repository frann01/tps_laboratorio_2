using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Artista
    {
        protected string nombre;
        protected ETipoArtista tipo;

        #region Constructores
        private Artista() { }
        public Artista(string nombre, ETipoArtista tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        #endregion

        #region Getters y Setters
        public string Nombre 
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public ETipoArtista Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        #endregion

        #region Sobrecargas
        public static bool operator ==(Artista b1, Artista b2)
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
                    if (b1.nombre == b2.nombre)
                    {
                        rta = true;
                    }
                }
            }

            return rta;
        }

        public static bool operator !=(Artista b1, Artista b2)
        {
            return !(b1 == b2);
        }

        public static implicit operator string(Artista a)
        {
            return a.nombre + ", " + a.tipo;
        }

        #endregion
    }
}
