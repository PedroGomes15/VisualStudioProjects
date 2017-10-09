using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetDiferente
{
    class Estoque
    {
        private string nome_produto;
        private double preco;

        public string NomeProduto
        {
            get {return nome_produto;}
            set {nome_produto = value;}
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
    }
}
