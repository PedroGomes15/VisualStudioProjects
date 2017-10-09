using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        bool cliquei_botão = false;
        double num1 = 0;
        bool mostrar_calculo = false;
        double calculo = 0;
        string qual_operacao = "";

        public void le_numero(int numero_lido)
        {
            if (!cliquei_botão)
            {
                tbNumero.Text += numero_lido;
            }
            else tbNumero.Text = numero_lido.ToString();
            cliquei_botão = false;
        }

        public void operacao(string operacao)
        {
            cliquei_botão = true;
            if (mostrar_calculo)
                calcula();
            this.qual_operacao = operacao;
            num1 = double.Parse(tbNumero.Text);

            mostrar_calculo = true;
        }

        public void calcula()
        {
            if (qual_operacao.Equals("+"))
                calculo = num1 + double.Parse(tbNumero.Text);
            else if (qual_operacao.Equals("/"))
                calculo = num1 / double.Parse(tbNumero.Text);
            else if (qual_operacao.Equals("*"))
                calculo = num1 * double.Parse(tbNumero.Text);
            else if (qual_operacao.Equals("-"))
                calculo = num1 - double.Parse(tbNumero.Text);

            tbNumero.Text = calculo.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void tbNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt8_Click(object sender, EventArgs e)
        {
            le_numero(8);
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            le_numero(0);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            le_numero(2);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            le_numero(3);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            le_numero(6);
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            le_numero(9);
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            le_numero(7);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            le_numero(5);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            le_numero(4);
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            le_numero(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operacao("/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operacao("*");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operacao("+");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operacao("-");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calcula();
            qual_operacao = "";
            mostrar_calculo = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tamanho = tbNumero.Text.Length;
            if (tamanho > 0)
                tbNumero.Text = tbNumero.Text.Substring(0, tamanho - 1); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbNumero.Text = "";
            num1 = 0;
            qual_operacao = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tbNumero.Text += ".";
        }
    }
}
