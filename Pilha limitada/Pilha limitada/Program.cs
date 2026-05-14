using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_limitada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();
            int[] entradas = { 1, 2, 3, 4 };

            foreach (int item in entradas)
            {
                if (pilha.Count >= 3)
                {
                    Console.WriteLine("Pilha cheia");
                }
                else
                {
                    pilha.Push(item);
                    Console.WriteLine("Adicionado: " + item);
                }
            }
        }
    }
}
