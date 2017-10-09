using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tipo_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //array list é usado para criar uma array sem um tipo especifico
            ArrayList cliente = new ArrayList();
            cliente.Add("Pedro Armando Miranda Gomes");
            cliente.Add("HappyCode");
            cliente.Add(19);
            cliente.Add(900.50);

            for (int i = 0; i < cliente.Count; i++)
                Console.WriteLine(cliente[i]);

            Console.ReadKey();
        }
    }
}
