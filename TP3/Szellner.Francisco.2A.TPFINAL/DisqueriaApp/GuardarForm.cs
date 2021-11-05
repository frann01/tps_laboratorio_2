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
    public partial class GuardarForm : Form
    {
        Tienda<Disco> tiendaAGuardar;
        public GuardarForm()
        {
            InitializeComponent();
        }

        public GuardarForm(Tienda<Disco> tienda):this()
        {
            this.tiendaAGuardar = tienda;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!String.IsNullOrEmpty(this.txtPath.Text))
                {
                    Tienda<Disco>.Guardar(tiendaAGuardar, this.txtPath.Text + ".xml");
                    this.DialogResult = DialogResult.OK;
                }
                else 
                {
                    MessageBox.Show("Por favor ingrese el nombre del archivo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ErrorArchivoException ex) 
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
