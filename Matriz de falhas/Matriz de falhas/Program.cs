using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizDeFalhas
{
    internal class Program
    {
        // Tarefa 3: Preencher Matriz 
        static void PreencherMatriz(int[,] matriz)
        {
            Random rnd = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(0, 21);
                }
            }
        }

        // Tarefa 4: Mostrar Falhas 
        static void MostrarFalhas(int[,] matriz)
        {
            Console.WriteLine("--- Lista de Falhas ---");

            foreach (int falha in matriz)
            {
                Console.Write($"| Falha: {falha} ");
            }
            Console.WriteLine("|");
        }

        // Tarefa 5: Calcular Total de Falhas
        static int CalcularTotalFalhas(int[,] matriz)
        {
            int somaTotal = 0;

            foreach (int f in matriz)
            {
                somaTotal += f; 
            }

            return somaTotal;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o número de ambientes: ");
            int amb = int.Parse(Console.ReadLine());
            Console.Write("Digite os tipos de Testes: ");
            int testes = int.Parse(Console.ReadLine());

            int[,] matrizFalhas = new int[amb, testes];

            PreencherMatriz(matrizFalhas);
            MostrarFalhas(matrizFalhas);

            int total = CalcularTotalFalhas(matrizFalhas);
            Console.WriteLine($"O total de falhas encontradas foi: {total}");

        }
    }
}