using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace db_sql_pokemon_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //criar conexao com o banco
            OleDbConnection conexao = new OleDbConnection(@"Provider=SQLOLEDB;Server=.\SQLEXPRESS;Database=Pokemon;User id=sa;pwd=sa@adm1");//nao pode ter espaços
            //executa uma instrução SQL
            OleDbCommand sql = new OleDbCommand("select * from pokemons", conexao);

            try
            {
                conexao.Open();//abre conexao
                OleDbDataReader lendo_dados = sql.ExecuteReader();
                while (lendo_dados.Read())
                {
                    rtbNome.Text += (lendo_dados.GetInt32(0) + " - " + lendo_dados.GetString(1) + "\n");//1 é o indice

                }

                lendo_dados.Close();
                conexao.Close();
            }
            catch (OleDbException erro_oledb)
            {
                MessageBox.Show("Erro " + erro_oledb, "Error");
            }
        }
    }
}
