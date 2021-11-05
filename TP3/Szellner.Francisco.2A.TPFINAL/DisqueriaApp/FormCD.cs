﻿using System;
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
    public partial class FormCD : FormDisco          
    {
        protected new CD discoDelForm;

        public FormCD():base()
        {
            InitializeComponent();
        }


        public override CD DiscoDelForm
        {
            get
            {
                return this.discoDelForm;
            }
        }

        protected override void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (String.IsNullOrEmpty(base.txtTItulo.Text) 
                    || base.cboGenero.SelectedItem == null 
                    || String.IsNullOrEmpty(base.txtNombreArtista.Text) 
                    || base.cboTipoArtista.SelectedItem == null 
                    || String.IsNullOrEmpty(base.txtPrecio.Text) 
                    || String.IsNullOrEmpty(base.txtAño.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.discoDelForm = new CD(base.txtTItulo.Text,
                (EGenero)base.cboGenero.SelectedItem,
                int.Parse(base.txtAño.Text),
                base.txtNombreArtista.Text,
                (ETipoArtista)base.cboTipoArtista.SelectedItem,
                float.Parse(base.txtPrecio.Text));

                    base.btn_Aceptar_Click(sender, e);
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