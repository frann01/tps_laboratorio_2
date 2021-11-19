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
    public partial class NuevaVentaForm : Form
    {
        protected Cliente clienteDelForm;
        public NuevaVentaForm()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(ESexo)))
            {
                this.cboSexo.Items.Add(item);
            }
        }

        public NuevaVentaForm(Disco discoAVender) :this()
        {

        }

        public Cliente ClienteDelForm 
        {
            get { return this.clienteDelForm; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int edad;
            if (String.IsNullOrEmpty(this.txtEdad.Text) || String.IsNullOrEmpty(this.txtNombre.Text) ||this.cboSexo.SelectedItem == null )
            {
                MessageBox.Show("Por favor llene todos los campos!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (int.TryParse(this.txtEdad.Text, out edad))
                {
                    try
                    {
                        this.clienteDelForm = new Cliente(this.txtNombre.Text, (ESexo)this.cboSexo.SelectedItem, edad);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (AñoInvalidoException excep)
                    {
                        MessageBox.Show(excep.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un numero!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
    }
}
