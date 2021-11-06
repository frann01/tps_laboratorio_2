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

        /// <summary>
        /// Setters y Getters publicos para que xml pueda guardarlos
        /// </summary>
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

        /// <summary>
        /// Al vender un disco lo elimina de la lista de stock, crea una nueva instancia de venta y lo agrega a la lista de ventas
        /// junto con el cliente
        /// </summary>
        /// <param name="tienda"></param>
        /// <param name="producto"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
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
        
        /// <summary>
        /// Muestra los datos de la tienda y dependiendo del tipo el stock, las ventas o los dos
        /// </summary>
        /// <param name="b"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Usa un serializar para leer un archivo tipo .xml
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Tienda<T> Leer(string path)
        {
            Serializador<Tienda<T>> datos = new Serializador<Tienda<T>>();
            Tienda<T> tienda;
            datos.Leer(path, out tienda);
            return tienda;
        }

        /// <summary>
        /// Guarda los datos de una tienda en un archivo .xml usando un serializador
        /// </summary>
        /// <param name="t"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool Guardar(Tienda<T> t, string path)
        {
            Serializador<Tienda<T>> xml = new Serializador<Tienda<T>>();

            return xml.Guardar(path, t);
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Indica si un producto se encuentra en stock
        /// </summary>
        /// <param name="b"></param>
        /// <param name="l"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Agrega un producto al stock si esta no esta ya en la lista
        /// </summary>
        /// <param name="b"></param>
        /// <param name="l"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Elimina un producto de la lista stock si este se encuentra en ella
        /// </summary>
        /// <param name="d"></param>
        /// <param name="item"></param>
        /// <returns></returns>
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
