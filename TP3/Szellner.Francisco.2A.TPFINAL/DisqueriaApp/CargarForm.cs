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
using Archivos;
using Excepciones;

namespace DisqueriaApp
{
    public partial class CargarForm : Form
    {
        Tienda<Disco> TiendaCargada;
        public CargarForm()
        {
            InitializeComponent();
        }

        public Tienda<Disco> TiendaDelForm 
        {
            get 
            {
                return this.TiendaCargada;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(this.txtPath.Text))
                {
                    this.TiendaCargada = Tienda<Disco>.Leer(this.txtPath.Text + ".xml");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese el nombre del archivo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo encontrar o no existe el archivo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
