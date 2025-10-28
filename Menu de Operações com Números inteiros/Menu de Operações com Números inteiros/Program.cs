using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Menu_de_Operações_com_Números_inteiros
{
    internal class Program
    {
        static string ParoImpar(int a)
        {
            if (a / 2 == 0)
            {
                return $"O numero {a} é par";
            }
            else
            {
                return $"O numero {a} é impar";
            }
        }

        static long CalcularFatorial(int a)
        {
            if (a == 0)
            {
                return 1;
            }

            long resultadofatorial = 1;

            for (int i = a; i >= 1; i--)
            {

                resultadofatorial *= i;
            }
            return resultadofatorial;
        }

        static int Calcmaior(int a, int b, int c)
        {

            int maior;

            if (a >= b && a >= c)
            {
                maior = a;
            }
            else if (b >= c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }

            return maior;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------- Qual operação você deseja fazer com numeros inteiros? -------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1- Verificar se o núemro é impar ou par.");
            Console.WriteLine("2- Calcular o fatorial de um número.");
            Console.WriteLine("3- Calcular o maior de três números");
            Console.WriteLine("4- Sair do programa...");

            int escolha = int.Parse(Console.ReadLine());

            int n1;

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Digite o número:");
                    n1 = int.Parse(Console.ReadLine());

                    ParoImpar(n1);
                    break;

                case 2:
                    Console.WriteLine("Digite o número:");
                    n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"O fatorial de {n1} é {CalcularFatorial(n1)}");
                    break;

                case 3:
                    Console.WriteLine("Digite o 1º número:");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o 2º número:");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o 3º número");
                    int n3 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"O maior número é {Calcmaior(n1, n2, n3)}");
                    break;

                case 4:
                    Console.WriteLine("Saindo do programa aperte ENTER para fechar..."); 
                    break;

                default:
                    Console.WriteLine("Operação invalida!");
                    break;
            }

        }
    }
}
