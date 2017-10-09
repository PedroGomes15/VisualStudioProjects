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
    public partial class Manipula : Form
    {
        public Manipula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Transforma todas em maiuscula
            lbResultado.Text = tbPalavra.Text.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Transforma todas em minuscula
            lbResultado.Text = tbPalavra.Text.ToLower();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Quebra o texto e pega uma parte especifica
            lbResultado.Text = tbPalavra.Text.Substring(0, 5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Retorna a posição que a palavra foi encontrada
            lbResultado.Text = tbPalavra.Text.IndexOf("Armando").ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Verifica se a frase começa por uma palavra/letra especifica
            if (tbPalavra.Text.StartsWith("Pedro"))
            {
                MessageBox.Show("Você é pedro", "Mensagem");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Verifica se a frase Termina por uma palavra/letra especifica

            if (tbPalavra.Text.EndsWith("Gomes"))
            {
                MessageBox.Show("Você é da familia Gomes", "Mensagem");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Insere o caracter defino em tantas casas(a esquerda)
            lbResultado.Text = tbPalavra.Text.PadLeft(30, '*');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Insere o caracter defino em tantas casas(a direita)
            lbResultado.Text = tbPalavra.Text.PadRight(30, '%');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Tira os espaços
            lbResultado.Text = tbPalavra.Text.Trim();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Tira os espaços do começo
            lbResultado.Text = tbPalavra.Text.TrimStart();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Tira os espaços do final
            lbResultado.Text = tbPalavra.Text.TrimEnd();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Quebra a string em um array de string;
            string[] array_palavra = tbPalavra.Text.Split(',');
            int tamanho_array = array_palavra.Length;
            for(int i = 0; i<tamanho_array;i++)
            {
                lbResultado.Text += "Posição " + i + ".:" + array_palavra[i] + " - "; 
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //une um array de string
            string[] nomes = { "Pedro", "Sarah", "Eliane" };
            string nomestring = String.Join(" ", nomes);
            lbResultado.Text = nomestring;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Format com 1 parametro
            MessageBox.Show(String.Format("Text Box é: {0}, e o meu nome é: {1}", tbPalavra.Text, "Pedro"));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Text Box é: {0}, e o meu nome é: {1:S} e minha idade é {2:D}", tbPalavra.Text, "Pedro", 19));
            //{1:S} obriga o parametro a ser uma string(S para string e D para inteiro(pode passar tambem o tamanho {0,10:D} e acrescenta brancos a direita), F para decimal, N decimal ou inteiro)
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int numero = 19;
            string numeroFormat = String.Format("Numero {0,8:D}",numero);
            MessageBox.Show(numeroFormat);
             numeroFormat = String.Format("Numero {0:D5}", numero);
            MessageBox.Show(numeroFormat);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string a = String.Format("Decimais normal {0:F}", 8.9);
            MessageBox.Show(a);
            a = String.Format("4 casas Decimais {0:F4}", 8.9f);
            MessageBox.Show(a);
            a = String.Format("Decimais com milhar {0:N2}", 85005.901f);
            MessageBox.Show(a);
            a = String.Format("Decimais com Moeda {0:C}", 8789.569f);
            MessageBox.Show(a);
            a = String.Format("Decimais percentual {0:P}", 0.89f);
            MessageBox.Show(a);
            a = String.Format("Percentual com casas {0:P6}", 0.89f);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            DateTime data_hora = System.DateTime.Now;
            String data = String.Format("Data atual completa {0:D}", data_hora);
            MessageBox.Show(data);
            data = String.Format("Data atual simples {0:d}", data_hora);
            MessageBox.Show(data);

            String hora = String.Format("Hora atual completa {0:T}", data_hora);
            MessageBox.Show(hora);
            hora = String.Format("Hora atual simples {0:t}", data_hora);
            MessageBox.Show(hora);

            String data_e_hora = String.Format("Data e hora Completa {0:F}",data_hora);
            MessageBox.Show(data_e_hora);
            data_e_hora = String.Format("Data completa e hora simples {0:f}", data_hora);
            MessageBox.Show(data_e_hora);
            data_e_hora = String.Format("Data simples e hora completa {0:G}", data_hora);
            MessageBox.Show(data_e_hora);
            data_e_hora = String.Format("Data e hora simples {0:g}", data_hora);
            MessageBox.Show(data_e_hora);

            //data e hora personalizados

            data = String.Format("Data com Dia e Mes {0:M}", data_hora);
            MessageBox.Show(data);
            data = String.Format("Data com Mes e Ano {0:Y}", data_hora);
            MessageBox.Show(data);
            data = String.Format("Data personalizada {0:dd/MM/yyyy}", data_hora);
            MessageBox.Show(data);
            data = String.Format("Hora personalizada {0:hh:mm:ss}", data_hora);
            MessageBox.Show(data);//se o h for H entao a hora sera 24
        }
    }
}
