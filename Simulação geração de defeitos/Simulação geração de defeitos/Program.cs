using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulação_de_geração_de_defeitos
{
    internal class Program
    {
        // Tarefa 2: Função para preencher o vetor com valores aleatórios
        static void GerarDefeitos(int[] defeitos)
        {
            Random rnd = new Random();
            for (int i = 0; i < defeitos.Length; i++)
            {
                defeitos[i] = rnd.Next(0, 11);
            }
        }

        // Tarefa 3: Função para percorrer com foreach e exibir os valores
        static void MostrarDefeitos(int[] defeitos)
        {
            Console.WriteLine("--- Relatório de Defeitos por Módulo ---");
            int contador = 1;
            foreach (int defeito in defeitos)
            {
                Console.WriteLine($"Módulo {contador}: {defeito} defeitos");
                contador++;
            }
        }

        // Tarefa 4: Função que retorna o total de defeitos
        static int CalcularTotal(int[] defeitos)
        {
            int soma = 0;
            foreach (int d in defeitos)
            {
                soma += d;
            }
            return soma;
        }

        static void Main(string[] args)
        {
            // Tarefa 1: Criar vetor dinamicamente com entrada do usuário
            Console.Write("Digite o número de módulos: ");
            int modulos = int.Parse(Console.ReadLine());

            int[] qntdDefeitos = new int[modulos];

            GerarDefeitos(qntdDefeitos);
            MostrarDefeitos(qntdDefeitos);

            int total = CalcularTotal(qntdDefeitos);
            Console.WriteLine($"Total de defeitos encontrados no software: {total}");
        }
    }
}