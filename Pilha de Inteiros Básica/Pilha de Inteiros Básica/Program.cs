using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_de_Inteiros_Básica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();
            string entrada;

            do
            {
                Console.Write("Digite um número (ou 'sair'): ");
                entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int num)) pilha.Push(num);
            } while (entrada.ToLower() != "sair");

            Console.WriteLine("Removendo números:");
            while (pilha.Count > 0)
            {
                Console.WriteLine(pilha.Pop());
            }
        }
    }
}
