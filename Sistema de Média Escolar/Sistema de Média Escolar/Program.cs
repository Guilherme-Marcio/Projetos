using System;
using System.Linq; 

namespace SistemaMediaEscolar
{
    class Program
    {
      
        static double Media(double[] notas)
        {
            
            if (notas == null || notas.Length == 0)
            {
                return 0.0; 
            }

            double soma = 0;

           
            foreach (double nota in notas)
            {
                soma += nota;
            }

            
            double mediaCalculada = soma / notas.Length;

            return mediaCalculada;
        }

        static void ExibirMenu()
        {
            Console.WriteLine("\n=====================================");
            Console.WriteLine("         MENU PRINCIPAL ");
            Console.WriteLine("=====================================");
            Console.WriteLine("1 - Calcular Média Geral");
            Console.WriteLine("2 - Mostrar a Maior Nota");
            Console.WriteLine("3 - Mostrar a Menor Nota");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("=====================================");
            Console.Write("Escolha uma opção: ");
        }


        static double[] SolicitaçãodeNotas()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("     Sistema de Média Escolar ");
            Console.WriteLine("=====================================");

            int qntdNotas = 0;

            
            do
            {
                Console.Write("Digite quantas notas você deseja inserir (de 1 a 5 notas): ");
                string input = Console.ReadLine();

                
                if (!int.TryParse(input, out qntdNotas) || qntdNotas < 1 || qntdNotas > 5)
                {
                    Console.WriteLine("⚠️ Erro! Digite um valor numérico válido de 1 até 5. Tente novamente.");
                    qntdNotas = 0; 
                }
            } while (qntdNotas == 0);

            
            double[] notas = new double[qntdNotas];

            
            for (int i = 0; i < qntdNotas; i++)
            {
                double nota = 0.0;
                bool notaValida = false;

               
                while (!notaValida)
                {
                    Console.Write($"Digite a {i + 1}ª nota: ");
                    string inputNota = Console.ReadLine();

                    if (double.TryParse(inputNota, out nota) && nota >= 0) 
                    {
                        notas[i] = nota;
                        notaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("❌ Entrada inválida. Digite um número positivo para a nota.");
                    }
                }
            }

            
            return notas;
        }

        

        static void Main(string[] args)
        {
            
            double[] notasDoAluno = SolicitaçãodeNotas();

            int opcao = 0;

            do
            {
                Console.Clear(); 
                ExibirMenu();

                
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.Clear();

                    switch (opcao)
                    {
                        case 1:
                           
                            double mediaGeral = Media(notasDoAluno);
                            Console.WriteLine($"\n A Média Geral das {notasDoAluno.Length} notas é: {mediaGeral:F2}");
                            break;

                        case 2:
                            double maiorNota = notasDoAluno.Max();
                            Console.WriteLine($"\n A Maior Nota inserida foi: {maiorNota:F2}");
                            break;

                        case 3:      
                            double menorNota = notasDoAluno.Min();
                            Console.WriteLine($"\n A Menor Nota inserida foi: {menorNota:F2}");
                            break;

                        case 4:
                            Console.WriteLine("\n Obrigado por usar o Sistema de Média Escolar! Até a próxima.");
                            break;

                        default:
                            Console.WriteLine("\n Opção inválida. Por favor, escolha uma opção de 1 a 4.");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n❌ Entrada inválida. Por favor, digite o número da opção desejada.");
                }

                if (opcao != 4)
                {
                    Console.WriteLine("\n(Pressione ENTER para voltar ao Menu...)");
                    Console.ReadLine();
                }

            } while (opcao != 4); 
        }
    }
}