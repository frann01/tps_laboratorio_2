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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonOperar_Click(object sender, EventArgs e)
        {
            Operando num1 = new Operando(textBoxNum1.Text);
            Operando num2 = new Operando(textBoxNum2.Text);
            char Operando = char.Parse(comboBoxOperando.Text);
            Calculadora calculadora = new Calculadora();
            string display;
            double resultado = calculadora.Operar(num1, num2, Operando);
            
            display = num1.Numero +" "+ Operando +" "+ num2.Numero + " = " + resultado;

            listBox1.Items.Add(display);
        }

        private void buttonBin_Click(object sender, EventArgs e)
        {

        }

        private void buttonDec_Click(object sender, EventArgs e)
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
