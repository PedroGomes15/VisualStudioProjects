using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<double> numeros = new List<double>();

            for(int c = 0; c<10; c++)
            {
                numeros.Add(rand.Next(0, 100));
                Console.Write(numeros[c] + " ");
            }

            Console.WriteLine("\nA media é: " + numeros.Average());
            Console.WriteLine("O maior numero é: " + numeros.Max());
            Console.WriteLine("O menor numero é: " + numeros.Min());
            Console.ReadKey();

        }
    }
}
