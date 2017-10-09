using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConexaoSqlServerSqlClientForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //criar a conexao do banco de dados
            SqlConnection conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Pokemon;User id=sa;pwd=sa@adm1");
            //executa uma instrução sql
            SqlCommand sql = new SqlCommand("select * from pokemons", conexao);

            try
            {
                conexao.Open();//abre a conexao
                SqlDataReader lendo_dados = sql.ExecuteReader();//leitor
                while (lendo_dados.Read())
                {
                    rtbText.Text += (lendo_dados.GetInt32(0) + " - " + lendo_dados.GetString(1) + "\n");//1 é o indice
                }
                lendo_dados.Close();
                conexao.Close();
            }
            catch (SqlException erro_sql)
            {
                MessageBox.Show("Erro " + erro_sql, "Error");
            }
        }
    }
}
