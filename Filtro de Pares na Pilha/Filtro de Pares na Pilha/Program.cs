using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtro_de_Pares_na_Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();
            string entrada;
            int contadorPares = 0;

            while (true)
            {
                Console.Write("Número ou 'sair': ");
                entrada = Console.ReadLine();
                if (entrada.ToLower() == "sair") break;
                if (int.TryParse(entrada, out int n)) numeros.Push(n);
            }

            while (numeros.Count > 0)
            {
                int atual = numeros.Pop();
                if (atual % 2 == 0)
                {
                    Console.WriteLine("Par: " + atual);
                    contadorPares++;
                }
            }
            Console.WriteLine("Total de pares: " + contadorPares);
        }
    }
}
