using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;//provedor do OleDb Microsoft.Jet.OLEDB.4.0

namespace banco_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar conexao com o banco
            OleDbConnection conexao = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\pedro\Documents\Visual Studio 2017\Projects\banco_de_dados\Banco_aula.mdb");
            //executa uma instrução SQL
            OleDbCommand sql = new OleDbCommand("select * from Nomes",conexao);

            try
            {
                conexao.Open();//abre conexao
                OleDbDataReader lendo_dados = sql.ExecuteReader();
                Console.WriteLine("Listando dados da tabela:");
                while (lendo_dados.Read())
                {
                    Console.WriteLine(lendo_dados.GetInt32(0) + " - " + lendo_dados.GetString(1));//1 é o indice
                    //outro tipo
                    //Console.WriteLine(lendo_dados["bai_nome"]);
                        
                }

                Console.WriteLine("Fim da Lista");
                Console.ReadKey();
                lendo_dados.Close();
                conexao.Close();
            }
            catch(OleDbException erro_oledb)
            {
                Console.WriteLine("Erro " + erro_oledb);
                Console.ReadKey();
            }
        }
    }
}
