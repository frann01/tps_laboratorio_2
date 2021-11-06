using System;
using System.Text;
using Excepciones;

namespace Entidades
{
    [Serializable]
    public abstract class Disco
    {
        protected string titulo;
        protected EGenero genero;
        protected Artista artista;
        protected int año;
        protected float precio;

        #region Constructores
        protected Disco() { }
        public Disco(string titulo, EGenero genero, int año, Artista artista, float precio) 
        {
            this.artista = artista;
            this.Año = año;
            this.titulo = titulo;
            this.genero = genero;
            this.Precio = precio;
        }
        public Disco(string titulo, EGenero genero, int año, string nombreArtista, ETipoArtista tipo, float precio) 
            :this(titulo, genero,año, new Artista(nombreArtista, tipo), precio) {}

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
        /// Valida que el precio sea mayor que 0
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        private float ValidarPrecio(float precio) 
        {
            if(precio <= 0) 
            {
                throw new PrecioInvalidoException();
            }
            return precio;
        }


        /// <summary>
        /// Valida que el año sea correcto
        /// </summary>
        /// <param name="año"></param>
        /// <returns></returns>
        private int ValidarAño(int año)
        {
            if (año < 1900 || año > 2022)
            {
                throw new AñoInvalidoException();
            }
            return año;
        }

        /// <summary>
        /// Muestra los datos base del disco
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        private static string Mostrar(Disco l)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Titulo: " + l.titulo +" - ");
            sb.AppendLine("Artista: " + (string)l.artista + " - ");
            sb.AppendLine("Genero: " + l.genero + " - ");
            sb.AppendLine("Año: " + l.año + " - ");
            sb.AppendLine("Precio: " + l.precio + " - ");

            return sb.ToString();
        }

        #endregion

        #region Sobrecargas

        public static explicit operator string(Disco a)
        {
            return Mostrar(a);
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
                    if (b1.titulo == b2.titulo && b1.artista == b2.artista)
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
