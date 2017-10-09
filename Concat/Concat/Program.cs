using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[4];
            nome[0] = "Pedro ";
            nome[1] = "Armando ";
            nome[2] = "Miranda ";
            nome[3] = "Gomes ";

            Console.WriteLine(nome[0] + nome[1] + nome[2] + nome[3]);
            Console.WriteLine(String.Concat(nome));
            //concat é usado para concatenar uma array

            double[] notas = new double[4];
            notas[0] = 5;
            notas[1] = 2;
            notas[2] = 8;
            notas[3] = 9;

            double soma = notas.Sum();
            //sum é usado para somar os valores de uma array
            double media = notas.Average();
            //Average é usado para tirar a media de uma array
            Console.WriteLine(soma);
            Console.WriteLine(media);

            Console.ReadKey();
        }
    }
}
