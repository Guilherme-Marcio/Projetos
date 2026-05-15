using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_de_Nomes_e_Ordem_Inversa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite um nome: ");
                nomes.Add(Console.ReadLine());
            }

            for (int i = nomes.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
