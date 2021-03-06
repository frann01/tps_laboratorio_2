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
    public partial class FormVinilo : FormDisco
    {
        protected new Vinilo discoDelForm;

        public FormVinilo():base()
        {
            InitializeComponent();

            foreach (var item in Enum.GetValues(typeof(ETipoVinilo)))
            {
                this.cboCondicionVinilo.Items.Add(item);
            }
        }

        public override Vinilo DiscoDelForm
        {
            get
            {
                return this.discoDelForm;
            }
        }

        protected override void btn_Aceptar_Click(object sender, EventArgs e)
        {
            int añoNuevo;
            float precioNuevo;
            try 
            {
                if (String.IsNullOrEmpty(base.txtTItulo.Text) 
                    || base.cboGenero.SelectedItem==null 
                    || String.IsNullOrEmpty(base.txtNombreArtista.Text) 
                    || base.cboTipoArtista.SelectedItem == null 
                    || String.IsNullOrEmpty(base.txtPrecio.Text) 
                    || this.cboCondicionVinilo.SelectedItem == null 
                    || String.IsNullOrEmpty(base.txtAño.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    if(int.TryParse(base.txtAño.Text ,out añoNuevo) && float.TryParse(base.txtPrecio.Text,out precioNuevo)) 
                    {
                        this.discoDelForm = new Vinilo
                                (base.txtTItulo.Text,
                                (EGenero)base.cboGenero.SelectedItem,
                                añoNuevo,
                                base.txtNombreArtista.Text,
                                (ETipoArtista)base.cboTipoArtista.SelectedItem,
                                (ETipoVinilo)this.cboCondicionVinilo.SelectedItem,
                                precioNuevo);

                        base.btn_Aceptar_Click(sender, e);
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
        
        protected override void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
