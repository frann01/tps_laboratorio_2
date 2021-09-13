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

namespace MiCalculadora
{
    
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void buttonOperar_Click(object sender, EventArgs e)
        {
            if(textBoxNum1.Text != "" && textBoxNum2.Text != "" && comboBoxOperando.Text != "") 
            {
                Operando num1 = new Operando(textBoxNum1.Text);
                Operando num2 = new Operando(textBoxNum2.Text);
                char operando = char.Parse(comboBoxOperando.Text);


                string display;
                double resultado = Operar(num1, num2, operando);

                display = num1.Numero + " " + operando + " " + num2.Numero + " = " + resultado;

                lblResultado.Text = resultado.ToString();
                lstOperaciones.Items.Add(display);
            }
        }

        private void buttonConvertirBin_Click(object sender, EventArgs e)
        {
            if(lblResultado.Text != "")
            {
                lblResultado.Text = Operando.decimalBinario(lblResultado.Text);
            }
            
        }

        private void buttonConvertirDec_Click(object sender, EventArgs e)
        {
            bool bandera = true;

            if (lblResultado.Text != "")
            {
                foreach (var item in lblResultado.Text)
                {
                    if (item != '1' && item != '0')
                    {
                        bandera = false;
                    }
                }

                if (bandera == true)
                {
                    lblResultado.Text = Operando.binarioDecimal(lblResultado.Text);
                }
            }
        }

        public static double Operar(Operando num1, Operando num2, char operador) 
        {
            double resultado = Calculadora.Operar(num1, num2, operador);
            return resultado;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
            lblResultado.Text = "0";
        }
        private void Limpiar() 
        {
            textBoxNum1.Text = "";
            textBoxNum2.Text="";
            lblResultado.Text = "";
            comboBoxOperando.Text = null;
        }
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = "Seguro de querer salir?";
            DialogResult rta = MessageBox.Show(mensaje, "Salir",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(rta == DialogResult.Yes) 
            {
                e.Cancel = false;
            }
            else 
            {
                e.Cancel = true;
            }
        }

     
    }
}
