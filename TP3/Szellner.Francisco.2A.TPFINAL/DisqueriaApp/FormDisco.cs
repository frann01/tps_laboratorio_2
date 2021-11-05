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
    public abstract partial  class FormDisco : Form
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
            this.DialogResult = DialogResult.OK;
        }

        protected virtual void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
