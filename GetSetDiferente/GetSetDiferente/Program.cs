using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetDiferente
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();

            estoque.NomeProduto = "Arroz";
            Console.Write(estoque.NomeProduto + " - ");
            estoque.Preco = 15.5;
            Console.Write(estoque.Preco);
            Console.ReadKey();
        }
    }
}
