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

namespace DisqueriaApp
{
    public partial class NuevaDisqueriaForm : Form
    {
        private Tienda<Disco> disqueriaDelForm;

        public Tienda<Disco> DisqueriaDelForm { get { return this.disqueriaDelForm; } }
        public NuevaDisqueriaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarNuevaDisqueria_Click(object sender, EventArgs e)
        {
            

            int cantidad;
            if(int.TryParse(this.txtCantidad.Text, out cantidad)) 
            {
                this.disqueriaDelForm = new Tienda<Disco>(cantidad);
                this.DialogResult = DialogResult.OK;
            }
            else 
            {
                MessageBox.Show("Por favor ingrese un numero!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelNewDisqueria_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
