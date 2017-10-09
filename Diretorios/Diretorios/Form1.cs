using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//entrada e saida

namespace Diretorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo diretorio = new DirectoryInfo(@"c:\CCharp");

            try
            {
                if (diretorio.Exists)
                    MessageBox.Show("Ja existe");
                else
                {
                    MessageBox.Show("Não existe, será criado...");
                    diretorio.Create();
                }
            }
            catch (IOException erro)
            {
                MessageBox.Show("Erro ao criar o diretorio");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo diretorio = new DirectoryInfo(@"c:\CCharp");

            try
            {
                if (diretorio.Exists)
                {
                    MessageBox.Show("Diretorio Existente será apagado...");
                    foreach (FileInfo file in diretorio.GetFiles())
                    {
                        file.Delete();
                    }
                    foreach (DirectoryInfo dir in diretorio.GetDirectories())
                    {
                        dir.Delete(true);
                    }
                }
                else
                {
                    MessageBox.Show("Diretorio não existe...");
                }
            }
            catch (IOException erro)
            {
                MessageBox.Show("Erro ao criar o diretorio " + erro.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DirectoryInfo diretorio = new DirectoryInfo(@"c:\CCharp");

            try
            {
                MessageBox.Show("Caminho.: " + diretorio.FullName);
            }
            catch (IOException erro)
            {
                MessageBox.Show("Erro ao criar o diretorio " + erro.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DirectoryInfo diretorio = new DirectoryInfo(@"c:\CCharp");

            try
            {
                diretorio.CreateSubdirectory(tbDirectName.Text);
                MessageBox.Show("Criada com sucesso...");
            }
            catch (IOException erro)
            {
                MessageBox.Show("Erro ao criar o diretorio " + erro.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileInfo arquivo = new FileInfo(@"C:\CCharp\arquivo.txt");
            try
            {
                FileStream fs = arquivo.Create();
                MessageBox.Show("Arquivo criado com sucesso... ("+ arquivo.CreationTime+")");
                MessageBox.Show("Tipo : " + arquivo.Attributes.ToString());
                MessageBox.Show("Nome completo: " + arquivo.FullName);
            }
            catch (IOException erro)
            {
                MessageBox.Show("Erro ao criar o arquivo " + erro.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\CCharp\arquivo.txt", FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(rtbTexto.Text);
            sw.Close();//grava e fecha
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\CCharp\arquivo.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string texto = sr.ReadToEnd();
            MessageBox.Show(texto);
        }
    }
}
