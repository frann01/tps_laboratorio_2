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
    [XmlInclude(typeof(Disco)), XmlInclude(typeof(Cliente))]
    public class Venta
    {
        private int id;
        protected Disco discoVendido;
        protected Cliente cliente;

        #region Constructores
        private Venta() { }
        public Venta(Disco discoVendido, Cliente cliente)
        {
            this.discoVendido = discoVendido;
            this.cliente = cliente;
        }

        public Venta(int id, Disco discoVendido, Cliente cliente) :this(discoVendido, cliente)
        {
            this.id = id;
        }

        #endregion

        #region Setters y Getters

        public Disco DiscoVendido
        {
            get
            {
                return this.discoVendido;
            }
            set { this.discoVendido = value; }

        }

        public Cliente Cliente
        {
            get
            {
                return this.cliente;
            }
            set { this.cliente = value; }
        }

        public int Id { get => id; set => id = value; }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Muestra los datos de la venta
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ID: " + this.id);
            sb.AppendLine("Cliente: ");
            sb.Append(this.cliente.ToString() + " - ");
            sb.AppendLine("Disco - ");
            sb.AppendLine(this.discoVendido.ToString());
            return sb.ToString();
        }

        #endregion
    }
}
