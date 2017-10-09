using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPrincipal
{
    public partial class Funcoes_Matematicas : Form
    {
        
        public Funcoes_Matematicas()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float num = float.Parse(tbNumero.Text);
            lbResultado.Text = "O raiz quadrada do " + num + " é = " + Math.Sqrt(num);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            float num = float.Parse(tbNumero.Text);
            lbResultado.Text = "O numero " + num + " ao quadrado é = " + Math.Pow(num, 2);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float num = float.Parse(tbNumero.Text);
            lbResultado.Text = "O inteiro desse " + num + " para cima é = " + Math.Ceiling(num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float num = float.Parse(tbNumero.Text);
            lbResultado.Text = "O inteiro desse " + num + " para baixo é = " + Math.Floor(num);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num = float.Parse(tbNumero.Text);
            lbResultado.Text = "O absoluto do numero " + num + " é = " + Math.Abs(num);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            float num = float.Parse(tbNumero.Text);
            lbResultado.Text = "O numero " + num + " arredondado é = " + Math.Round(num);
        }
    }
}
