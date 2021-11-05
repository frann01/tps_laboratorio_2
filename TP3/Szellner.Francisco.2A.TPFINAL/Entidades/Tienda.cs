using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;
using Archivos;

namespace Entidades
{
    [XmlInclude(typeof(List<Venta>)), XmlInclude(typeof(List<Disco>))]
    public class Tienda<T> where T : Disco
    {
        private int capacidad;
        private List<T> stock;
        private List<Venta> ventas;
        private float ganancia;


        #region Constructores
        private Tienda()
        {
            this.stock = new List<T>();
            this.ventas = new List<Venta>();
            this.ganancia = 0;
        }

        public Tienda(int cantidad) : this()
        {
            this.capacidad = cantidad;
        }
        #endregion

        #region Getters y setters
        public string Stock
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Discos: ");
                foreach(T item in this.stock)
                {
                    sb.AppendLine(item.ToString());
                }
                return sb.ToString();
            }
        }

        public List<T> StockListado
        {
            get
            {
                return this.stock;
            }
        }

        public List<Venta> VentasListado
        {
            get
            {
                return this.ventas;
            }
        }

        public float Ganacia
        {
            set
            {
                this.ganancia += value;
            }

            get 
            {
                return this.ganancia;
            }
        }

        public int Cantidad 
        {
            set 
            {
                this.capacidad = value;
            }
            get { return this.capacidad; }
        }
        
        public string Vendidos
        {
            get
            {

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Vendidos: ");
                foreach(Venta item in this.ventas)
                {
                    sb.AppendLine(item.ToString());
                }
                return sb.ToString();
            }
        }

        #endregion

        #region Funciones

        public static int Vender(Tienda<T> tienda, T producto, Cliente cliente) 
        {
            int retorno = 1;
            if(cliente != null) 
            {
                Venta nuevaVenta = new Venta(producto, cliente);
                tienda.ventas.Add(nuevaVenta);
                tienda -= producto;
                retorno = 0;
            }

            return retorno;
        }
        
        public static string Mostrar(Tienda<T> b, ETipoMostrar tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Disqueria");
            sb.AppendLine("Cantidad Maxima: " + b.capacidad);
            sb.AppendLine("Ganancia: " + b.ganancia);
            sb.AppendLine("**************************");
            sb.AppendLine();
            switch (tipo) 
            {
                case ETipoMostrar.Stock:
                    sb.AppendLine(b.Stock);
                    break;

                case ETipoMostrar.Vendidos:
                    sb.AppendLine(b.Vendidos);
                    break;

                case ETipoMostrar.Todos:
                    sb.AppendLine(b.Stock);
                    sb.AppendLine(b.Vendidos);
                    break;
            }

            return sb.ToString();
        }

        public static Tienda<T> Leer(string path)
        {
            Serializador<Tienda<T>> datos = new Serializador<Tienda<T>>();
            Tienda<T> tienda;
            datos.Leer(path, out tienda);
            return tienda;
        }

        public static bool Guardar(Tienda<T> t, string path)
        {
            Serializador<Tienda<T>> xml = new Serializador<Tienda<T>>();

            return xml.Guardar(path, t);
        }

        #endregion

        #region Sobrecargas
        public static bool operator ==(Tienda<T> b, T l)
        {
            bool rta = false;

            foreach (T item in b.stock)
            {
                if (item.Equals(l))
                {
                    rta = true;
                    break;
                }

            }

            return rta;
        }

        public static bool operator !=(Tienda<T> b, T l)
        {

            return !(b == l);
        }

        public static Tienda<T> operator +(Tienda<T> b, T l)
        {
            if (b == l)
            {
                throw new DiscoRepetidoException();
            }
            else
            {

                if (b.capacidad == b.stock.Count)
                {

                    throw new SinLugarException();
                }
                else
                {
                    b.stock.Add(l);
                }
            }

            return b;
        }

        public static Tienda<T> operator -(Tienda<T> d, T item)
        {
            if (d.stock.Count > 0)
            {
               if (d == item)
               {
                    d.Ganacia = item.Precio;
                   d.stock.Remove(item);
               }
               else
               {
                    throw new NoEstaenDisqueriaException();
               }
                
            }
            else 
            {
                throw new NoEstaenDisqueriaException();
            }

            return d;
        }



        #endregion
    }
}
