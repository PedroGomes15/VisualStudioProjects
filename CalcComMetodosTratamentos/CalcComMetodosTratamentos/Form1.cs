using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcComMetodosTratamentos
{
    public partial class Form1 : Form
    {
        double n1, n2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Subtrair_Click(object sender, EventArgs e)
        {
            converter();
            resultado = n1 - n2;
            tbResultado.Text = resultado.ToString();
        }

        private void bt_Multiplicar_Click(object sender, EventArgs e)
        {
            converter();
            resultado = n1 * n2;
            tbResultado.Text = resultado.ToString();
        }

        private void bt_Dividir_Click(object sender, EventArgs e)
        {
            converter();
            resultado = n1 / n2;
            tbResultado.Text = resultado.ToString();
        }

        private void bt_Soma_Click(object sender, EventArgs e)
        {
            converter();
            resultado = n1 + n2;
            tbResultado.Text = resultado.ToString(); 
        }

        private void converter()
        {
            try
            {
                n1 = double.Parse(tb_Num1.Text);
                n2 = double.Parse(tb_Num2.Text);
            }
            catch
            {
                MessageBox.Show("Não foi possivel converter", "Error");
            }
        }
    }
}
