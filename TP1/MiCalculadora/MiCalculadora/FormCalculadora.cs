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
            if(textBoxNum1.Text != null && textBoxNum2.Text != null && comboBoxOperando.Text != null) 
            {
                Operando num1 = new Operando(textBoxNum1.Text);
                Operando num2 = new Operando(textBoxNum2.Text);
                char operando = char.Parse(comboBoxOperando.Text);


                string display;
                double resultado = Operar(num1, num2, operando);

                display = num1.Numero + " " + operando + " " + num2.Numero + " = " + resultado;

                listBox1.Items.Add(display);
            }
        }

        private void buttonConvertirBin_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonConvertirDec_Click(object sender, EventArgs e)
        {

        }

        public double Operar(Operando num1, Operando num2, char operador) 
        {
            Calculadora calculadora = new Calculadora();
            double resultado = calculadora.Operar(num1, num2, operador);
            return resultado;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
            comboBoxOperando.Items.Add('+');
            comboBoxOperando.Items.Add('-');
            comboBoxOperando.Items.Add('*');
            comboBoxOperando.Items.Add('/');
        }
        private void Limpiar() 
        {
            listBox1.Items.Clear();
            textBoxNum1.Clear();
            textBoxNum2.Clear();
            comboBoxOperando.Items.Clear();
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
