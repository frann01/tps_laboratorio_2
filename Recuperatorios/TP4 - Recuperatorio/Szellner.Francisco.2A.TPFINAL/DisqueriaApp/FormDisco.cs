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
    public partial class FormDisco : Form
    {
        protected  Disco discoDelForm;
        public FormDisco()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(EGenero)))
            {
                this.cboGenero.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(ETipoArtista)))
            {
                this.cboTipoArtista.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(ETipoDisco)))
            {
                this.cboTipo.Items.Add(item);
            }

        }

        public virtual Disco DiscoDelForm 
        {
            get 
            {
                return this.discoDelForm;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void btn_Aceptar_Click(object sender, EventArgs e)
        {
            int añoNuevo;
            float PrecioNuevo;

            try
            {
                if (String.IsNullOrEmpty(this.txtTItulo.Text)
                    || this.cboGenero.SelectedItem == null
                    || String.IsNullOrEmpty(this.txtNombreArtista.Text)
                    || this.cboTipoArtista.SelectedItem == null
                    || String.IsNullOrEmpty(this.txtPrecio.Text)
                    || String.IsNullOrEmpty(this.txtAño.Text) || this.cboTipo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor llene todos los campos!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (int.TryParse(this.txtAño.Text, out añoNuevo) && float.TryParse(this.txtPrecio.Text, out PrecioNuevo))
                    {
                        this.discoDelForm = new Disco(this.txtTItulo.Text,
                (EGenero)this.cboGenero.SelectedItem,
                añoNuevo,
                this.txtNombreArtista.Text,
                (ETipoArtista)this.cboTipoArtista.SelectedItem,
                PrecioNuevo, (ETipoDisco) this.cboTipo.SelectedItem);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese los tipos de datos correctos!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (AñoInvalidoException excep)
            {
                MessageBox.Show(excep.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (PrecioInvalidoException excep)
            {
                MessageBox.Show(excep.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected virtual void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
