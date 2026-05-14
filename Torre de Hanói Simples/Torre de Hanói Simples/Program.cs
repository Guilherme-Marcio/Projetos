using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_de_Hanói_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int discos = 3;
            Mover(discos, 'A', 'C', 'B');
        }

        static void Mover(int n, char origem, char destino, char auxiliar)
        {
            if (n > 0)
            {
                Mover(n - 1, origem, auxiliar, destino);
                Console.WriteLine($"Mover disco {n} do pino {origem} para o pino {destino}");
                Mover(n - 1, auxiliar, destino, origem);
            }
        }
    }
}
    

