using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_Metodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_Ultima.Text = cb_Pegar.Items[cb_Pegar.Items.Count - 1].ToString();
        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            adiciona(textBox1.Text);
            
        }

        private void adiciona(string aux)
        {
            cb_Pegar.Items.Add(aux);
            MessageBox.Show(aux, "Gostosa Adicionada");
            lb_Ultima.Text = cb_Pegar.Items[cb_Pegar.Items.Count - 1].ToString();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            limpa();
        }

        private void limpa()
        {
            cb_Pegar.Items.Clear();
        }
    }
}
