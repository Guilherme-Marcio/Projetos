using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizTestesQA
{
    internal class Program
    {
        // Tarefa 3: Função GerarExecucoes() para preencher a matriz
        // Tarefa 2: Valores aleatórios entre 10 e 100
        static void GerarExecucoes(int[,] matriz)
        {
            Random rnd = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++) 
            {
                for (int j = 0; j < matriz.GetLength(1); j++) 
                {
                    matriz[i, j] = rnd.Next(10, 101); 
                }
            }
        }

        // Tarefa 4: Função MostrarExecucoes() usando FOREACH
        static void MostrarExecucoes(int[,] matriz)
        {
            Console.WriteLine("--- Relatório de Execuções (Visão Geral) ---");
            foreach (int teste in matriz)
            {
                Console.Write($"[{teste}] ");
            }
            Console.WriteLine();
        }

        // Tarefa 5: Função CalcularTotalTestes() que RETORNA o total
        static int CalcularTotalTestes(int[,] matriz)
        {
            int total = 0;
            foreach (int teste in matriz)
            {
                total += teste;
            }
            return total;
        }

        static void Main(string[] args)
        {
            // Tarefa 1: Criar matriz dinâmica com base no input do usuário
            Console.Write("Digite o número de dias analisados: ");
            int dias = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de tipos de testes por dia: ");
            int tipos = int.Parse(Console.ReadLine());

            int[,] matrizTestes = new int[dias, tipos];

            GerarExecucoes(matrizTestes);
            MostrarExecucoes(matrizTestes);

            int totalGeral = CalcularTotalTestes(matrizTestes);
            Console.WriteLine($"Total de testes executados no período: {totalGeral}");

            Console.WriteLine("Pressione qualquer tecla para sair...");
        }
    }
}