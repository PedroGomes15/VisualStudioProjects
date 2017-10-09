using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pega_erros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero..:");
            //try é um comando usado para tentar executar uma parte do codigo
            try
            {
                int numero = int.Parse(Console.ReadLine());
                for (int i = 1; i<=9;i++)
                {
                    Console.WriteLine(numero + " * " +  i + " = " + (numero * i));
                }
            }
            //caso ocorra um erro cai no catch e é imprimido o erro
            catch(Exception error)
            {
                Console.WriteLine("Você nao digitou um numero - Erro = " + error);
            }
            //finally é a finalização da application independe se ocorrer um erro ou nao
            finally
            {
                Console.Write("Aperte qualquer tecla...");
                Console.ReadKey();
            }
        }
    }
}
