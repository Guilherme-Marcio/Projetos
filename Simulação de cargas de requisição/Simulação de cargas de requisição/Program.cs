using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos3._4
{
    internal class Program
    {
        // Tarefa 3: Criar uma função GerarRequisicoes() para preencher o vetor
        // Tarefa 2: Gerar valores aleatórios entre 100 e 1000
        static void GerarRequisicao(int[] vetor)
        {
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(100, 1001);
            }
        }

        // Tarefa 4: Criar uma função ExibirRequisicoes() 
        static void ExibirRequisicao(int[] vetor)
        {
            Console.WriteLine("--- Carga dos Servidores ---");
            foreach (int carga in vetor) 
            {
                Console.WriteLine($"{carga} requisições");
            }
        }

        // Tarefa 5: Criar uma função MaiorCarga() que retorne o maior número
        static int MaiorCarga(int[] vetor)
        {
            int maior = vetor[0];
            foreach (int carga in vetor) 
            {
                if (carga > maior)
                {
                    maior = carga;
                }
            }
            return maior; 
        }

        static void Main(string[] args)
        {
            // Tarefa 1: Criar um vetor dinâmico para armazenar as requisições
            Console.Write("Quantos servidores participaram do teste? ");
            int a = int.Parse(Console.ReadLine());

            int[] vetor = new int[a];

            GerarRequisicao(vetor);
            ExibirRequisicao(vetor);

            int maiorValor = MaiorCarga(vetor);
            Console.WriteLine($"O servidor com maior carga processou: {maiorValor} requisições");

        }
    }
}