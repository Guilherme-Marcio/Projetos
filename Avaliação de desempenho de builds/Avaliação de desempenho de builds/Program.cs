using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoBuilds
{
    internal class Program
    {
        // Tarefa 3: Função para gerar os valores (entre 50 e 300) e preencher tempos
        static void PreencherTempos(int[] tempos)
        {
            Random rnd = new Random();
            for (int i = 0; i < tempos.Length; i++)
            {
                tempos[i] = rnd.Next(50, 301);
            }
        }

        // Tarefa 4: Função para mostrar tempos usando FOREACH
        static void MostrarTempos(int[] tempos)
        {
            Console.WriteLine("--- Tempos de Execução das Builds ---");
            int buildNum = 1;
            foreach (int tempo in tempos)
            {
                Console.WriteLine($"Build #{buildNum}: {tempo} segundos");
                buildNum++;
            }
        }

        // Tarefa 5: Função para calcular a média (Retorna double para precisão)
        static double CalcularMedia(int[] tempos)
        {
            double soma = 0;
            foreach (int tempo in tempos)
            {
                soma += tempo;
            }
            return soma / tempos.Length;
        }

        static void Main(string[] args)
        {
            // Tarefa 1: Criar vetor dinamicamente
            Console.Write("Informe a quantidade de builds executados: ");
            int quantidade = int.Parse(Console.ReadLine());

            int[] builds = new int[quantidade];

            PreencherTempos(builds);
            MostrarTempos(builds);

            double media = CalcularMedia(builds);
            Console.WriteLine($"A média de tempo das builds foi: {media} segundos");

            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}