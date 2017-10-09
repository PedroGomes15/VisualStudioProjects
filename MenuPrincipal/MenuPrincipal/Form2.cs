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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cbEmail_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            if (cbEmail.Checked)
                MessageBox.Show("Obrigado!\nEmail será enviado...", "Email");
            else
                MessageBox.Show("Desculpe!\nEmail não será enviado...", "Email");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
