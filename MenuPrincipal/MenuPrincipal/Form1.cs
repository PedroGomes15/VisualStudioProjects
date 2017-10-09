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
    public partial class Menu : Form
    {
        DateTime data_hora;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lbDataHora.Text = "Data: " + data_hora.ToLongDateString() + " Hora: " + data_hora.ToLongTimeString();
        }

        private void btChamaForm_Click(object sender, EventArgs e)
        {
            DataEHora frmDataEHora = new DataEHora();
            frmDataEHora.ShowDialog();
        }

        private void dataEHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btChamaForm_Click(sender, e);
        }

        private void checkBoxRadioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm_cbRb = new Form2();
            frm_cbRb.ShowDialog();
        }

        private void mascarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mascaras frm_Mascaras = new Mascaras();
            frm_Mascaras.ShowDialog();
        }

        private void manipulaStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manipula frm_Manipula = new Manipula();
            frm_Manipula.ShowDialog();
        }

        private void funçõesMatematicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcoes_Matematicas frm_FuncoesMatematicas = new Funcoes_Matematicas();
            frm_FuncoesMatematicas.ShowDialog();
        }
    }
}
