using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = double.Parse(tb_Num1.Text);
            n2 = double.Parse(tb_Num2.Text);
            double soma = n1 + n2;
            tbResultado.Text = soma.ToString();
        }

        private void bt_Subtrair_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = double.Parse(tb_Num1.Text);
            n2 = double.Parse(tb_Num2.Text);
            double subtrair = n1 - n2;
            tbResultado.Text = subtrair.ToString();
        }

        private void bt_Multiplicar_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = double.Parse(tb_Num1.Text);
            n2 = double.Parse(tb_Num2.Text);
            double multiplicar = n1 * n2;
            tbResultado.Text = multiplicar.ToString();
        }

        private void bt_Dividir_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = double.Parse(tb_Num1.Text);
            n2 = double.Parse(tb_Num2.Text);
            double dividir = n1 / n2;
            tbResultado.Text = dividir.ToString();
        }
    }
}
