using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Evento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void btLer_Click(object sender, EventArgs e)
        {
            tbNomeLido.Text = tb_nome.Text;
            MessageBox.Show("Nome digitado: " + tb_nome.Text, "Mensagem do mestre");
        }
    }
}
