using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    public class Cliente
    {
        protected string nombre;
        protected ESexo sexo;
        protected int edad;

        #region Constructores
        private Cliente() { }
        public Cliente(string nombre, ESexo sexo, int edad)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.Edad = edad;
        }

        #endregion

        #region Setters y Getters
        public int Edad
        {
            set
            {
                this.edad = this.ValidarEdad(value);
            }
            get
            {
                return this.edad;
            }
        }
        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get { return this.nombre; }
        }
        public ESexo Sexo { set { this.sexo = value; } get { return this.sexo; } }

        #endregion

        #region Funciones
        private int ValidarEdad(int edad)
        {
            if (edad <= 0 || edad > 120)
            {
                throw new EdadInvalidaException();
            }
            return edad;
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append( this.nombre + ",");
            sb.Append(" " + this.sexo+",");
            sb.Append(" " + this.edad +" años");
            sb.AppendLine("");
            return sb.ToString();
        }

        #endregion
    }
}
