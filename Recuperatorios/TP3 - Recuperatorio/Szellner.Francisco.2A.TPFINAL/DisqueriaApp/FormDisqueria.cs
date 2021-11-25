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

        }

        public FormDisqueria(Tienda<Disco> disqueria) :this()
        {
            this.disqueria = disqueria;
            this.ActualizarListadoStock();
            this.ActualizarListadoVendidos();
            this.txtGanancia.Text = string.Format("{0:C}", this.disqueria.Ganacia);
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
            this.AgregarDisco(sender, e);
        }

        private void btn_NuevoCd_Click(object sender, EventArgs e)
        {
            this.AgregarDisco(sender, e);
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

        
        /// <summary>
        /// Crea instancia del form correcto segun que boton fue presionado 
        /// Uso de excepciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarDisco(object sender, EventArgs e)
        {
            FormDisco frm = null;

            if (((Button)sender).Name == "btn_NuevoVinilo")
            {
                frm = new FormVinilo();
            }
            
            if (((Button)sender).Name == "btn_NuevoCd")
            {
                frm = new FormCD();
            }
            
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

            foreach (Venta item in this.disqueria.VentasListado)
            {
                this.lstVendidos.Items.Add(item);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarForm frm = new GuardarForm(this.disqueria);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Tienda guardada exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_informes_Click(object sender, EventArgs e)
        {
            if(this.disqueria.VentasListado.Count > 0)
            {
                InformesForm frm = new InformesForm(this.disqueria);
                frm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Todavia no se realizo ninguna compra!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
