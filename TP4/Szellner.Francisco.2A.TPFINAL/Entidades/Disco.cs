using System;
using System.Text;
using Excepciones;

namespace Entidades
{
    [Serializable]
    public class Disco
    {
        protected string titulo;
        protected EGenero genero;
        protected ETipoDisco tipo;
        protected Artista artista;
        protected int año;
        protected float precio;

        #region Constructores
        protected Disco() { }
        public Disco(string titulo, EGenero genero, int año, Artista artista, float precio, ETipoDisco tipo) 
        {
            this.artista = artista;
            this.Año = año;
            this.titulo = titulo;
            this.genero = genero;
            this.Precio = precio;
            this.tipo = tipo;
        }
        public Disco(string titulo, EGenero genero, int año, string nombreArtista, ETipoArtista tipoAr, float precio, ETipoDisco tipo) 
            :this(titulo, genero,año, new Artista(nombreArtista, tipoAr), precio, tipo) {}

        #endregion

        #region Getters y setters

        public float Precio 
        { 
            get
            {
                return this.precio;
            }
            set 
            {
                this.precio = this.ValidarPrecio(value);
            }
        }

        public ETipoDisco TipoDIsco
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        public int Año 
        {
            set 
            {
                this.año = this.ValidarAño(value);
            }
            get { return this.año; }
        }

        public EGenero Genero
        {
            get
            {
                return this.genero;
            }
            set { this.genero = value; }
        }
        
        public Artista Artista 
        { 
            set 
            {
                this.artista = value;
            }
            get { return this.artista; }
        }
        public string Titulo 
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        #endregion

        #region Funciones
        

        /// <summary>
        /// Muestra los datos base del disco
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        private static string Mostrar(Disco l)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: " + l.tipo + " - ");
            sb.AppendLine("Titulo: " + l.titulo +" - ");
            sb.AppendLine("Artista: " + (string)l.artista + " - ");
            sb.AppendLine("Genero: " + l.genero + " - ");
            sb.AppendLine("Año: " + l.año + " - ");
            sb.AppendLine("Precio: " + l.precio + " - ");

            return sb.ToString();
        }

        #endregion

        #region Sobrecargas

        public override string ToString()
        {
            return Mostrar(this);
        }

        /// <summary>
        /// Compara que dos discos tenga el mismo titulo y artista
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        public static bool operator ==(Disco b1, Disco b2)
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
                    if (b1.titulo == b2.titulo && b1.artista == b2.artista && b1.tipo == b2.tipo)
                    {
                        rta = true;
                    }
                }
            }

            return rta;
        }

        public static bool operator !=(Disco b1, Disco b2)
        {

            return !(b1 == b2);
        }

        #endregion
    }
}
