using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardConexaodata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nomesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nomesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_aulaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_aulaDataSet.Nomes'. Você pode movê-la ou removê-la conforme necessário.
            this.nomesTableAdapter.Fill(this.banco_aulaDataSet.Nomes);

        }
    }
}
