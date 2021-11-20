using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace DisqueriaApp
{
    public partial class FormDisqueria : Form
    {
        private Tienda<Disco> disqueria;

        public FormDisqueria()
        {
            InitializeComponent();
            Task tCargarVentas = new Task(cargarVentas);
            this.disqueria = new Tienda<Disco>(200);
            this.disqueria.CargarGanacia();

            this.disqueria.VentaNueva += MostrarDiscoVendido;
            tCargarVentas.RunSynchronously();
            this.disqueria.VentasListado = AccesoDatos.ObtenerListaVentas();

            this.txtGanancia.Text = string.Format("{0:C}", this.disqueria.Ganacia);
            this.ActualizarListadoStock();
            this.ActualizarListadoVendidos();
        }

        private void cargarVentas() 
        {
            this.disqueria.StockListado = Tienda<Disco>.Leer("StockDisqueria.xml");
        }

        public Tienda<Disco> Disqueria 
        {
            get 
            {
                return this.disqueria;
            }

        }

        #region Funciones
        private void btn_NuevoVinilo_Click(object sender, EventArgs e)
        {
            FormDisco frm = new FormDisco();

            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.disqueria += frm.DiscoDelForm;
                    this.ActualizarListadoStock();
                }
                catch (SinLugarException excep)
                {
                    MessageBox.Show(excep.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btn_Vender_Click(object sender, EventArgs e)
        {
            if (this.lstStock.SelectedItem != null)
            {
                Disco disco = (Disco)this.lstStock.SelectedItem;
                NuevaVentaForm frm = new NuevaVentaForm(disco);

                frm.StartPosition = FormStartPosition.CenterScreen;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Tienda<Disco>.Vender(this.disqueria, disco, frm.ClienteDelForm);
                    this.txtGanancia.Text = string.Format("{0:C}", this.disqueria.Ganacia);
                    this.ActualizarListadoStock();
                    this.ActualizarListadoVendidos();
                }

                
            }
            else 
            {
                MessageBox.Show("Por favor seleccione un disco disponible!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MostrarDiscoVendido(Venta venta) 
        {
            string texto = "Se ha vendido el disco " + venta.DiscoVendido.Titulo + " a " + venta.Cliente.Nombre + " por " + venta.DiscoVendido.Precio + " pesos!";
            MessageBox.Show(texto, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Actualiza el listbox con el stock
        /// </summary>
        private void ActualizarListadoStock()
        {
            this.lstStock.Items.Clear();

            foreach (Disco item in this.disqueria.StockListado)
            {
                this.lstStock.Items.Add(item);
            }
        }

        private void ActualizarListadoVendidos()
        {
            this.lstVendidos.Items.Clear();
            this.disqueria.VentasListado = AccesoDatos.ObtenerListaVentas();

            foreach (Venta item in this.disqueria.VentasListado)
            {
                this.lstVendidos.Items.Add(item);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try 
            {
                Tienda<Disco>.Guardar(this.disqueria, "StockDisqueria.xml");
                MessageBox.Show("Stock guardado exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ErrorArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_informes_Click(object sender, EventArgs e)
        {
            if(this.disqueria.VentasListado.Count > 0)
            {
                InformesForm frm = new InformesForm();
                frm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Todavia no se realizo ninguna compra!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void brn_Eliminar_Disco_Click(object sender, EventArgs e)
        {
            if (this.lstStock.SelectedItem != null)
            {
                Disco disco = (Disco)this.lstStock.SelectedItem;
                DialogResult d =  MessageBox.Show("Desea eliminar el disco "+ disco.Titulo+"?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (d == DialogResult.Yes)
                {
                    this.disqueria -= disco;
                    this.ActualizarListadoStock();
                    this.ActualizarListadoVendidos();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un disco disponible!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormDisqueria_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.disqueria.GuardarGanacia();
        }
    }
}
