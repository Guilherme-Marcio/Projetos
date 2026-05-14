using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_de_Hanói_Avançada
{
    internal class Program
    {
        static Stack<int> pinoA = new Stack<int>();
        static Stack<int> pinoB = new Stack<int>();
        static Stack<int> pinoC = new Stack<int>();
        static int movimentos = 0;
        static void Main(string[] args)
        {
            Console.Write("Número de discos (1-8): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--) pinoA.Push(i);

            MostrarEstado();
            Resolver(n, pinoA, pinoC, pinoB, 'A', 'C', 'B');
            Console.WriteLine($"Torre de Hanói resolvida em {movimentos} movimentos!");
        }

        static void Resolver(int n, Stack<int> ori, Stack<int> des, Stack<int> aux, char o, char d, char a)
        {
            if (n > 0)
            {
                Resolver(n - 1, ori, aux, des, o, a, d);
                des.Push(ori.Pop());
                movimentos++;
                Console.WriteLine($"Mover do pino {o} para o {d}");
                MostrarEstado();
                Resolver(n - 1, aux, des, ori, a, d, o);
            }
        }

        static void MostrarEstado()
        {
            Console.WriteLine("Pino A: " + string.Join(" ", pinoA.Reverse()));
            Console.WriteLine("Pino B: " + string.Join(" ", pinoB.Reverse()));
            Console.WriteLine("Pino C: " + string.Join(" ", pinoC.Reverse()));
            Console.WriteLine("------------------");
        }
    }
}
