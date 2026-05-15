using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Inteiros_e_Exibição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);
            numeros.Add(40);
            numeros.Add(50);

            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
        }
    }
}
