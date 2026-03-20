using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static double Somar(double a, double b)
        {
            return a + b;
        }

        static double Subtrair(double a, double b)
        {
            return a - b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static double Divisao(double a, double b)
        {
            if (b == 0)
            {

                Console.WriteLine("Divisão por 0 não é permitida");
                return 0;

            }
            return a / b;
        }

        static double Seno(double catetoOposto, double hipotenusa)
        {
            return (catetoOposto / hipotenusa);
        }

        static double Potencia(double a, double b)
        {
            return Math.Pow(a, b);
        }

        static double Cosseno(double catetoAdj, double hipotenusa)
        {
            return catetoAdj / hipotenusa;
        }

        static double Tangente(double catetoOposto, double catetoAdj)
        {
            return catetoOposto / catetoAdj;
        }

        static double Hipotenusa(double catetoOposto, double catetoAdj)
        {
            double h = Math.Pow(catetoOposto, 2) + Math.Pow(catetoAdj, 2);
            return Math.Pow(h, 2);
        }

        static void MostrarResultado(double resultado)
        {
            Console.WriteLine($"O resultado é: {resultado}");
        }

        static void Main(string[] args)
        {
            char operacao;
            string resposta;
            double num1, num2;
            bool continuar = true;
            double[] Resultados = new double[100];
            int contador = 0;

            Console.WriteLine(" CALCULADORA EM C#");
            Console.WriteLine("--------------------");

            while (continuar)
            {
                Console.WriteLine("Escolha a operação que você deseja fazer:");
                Console.WriteLine("Digite + para Somar");
                Console.WriteLine("Digite - para Subtrair");
                Console.WriteLine("Digite * para Multiplicar");
                Console.WriteLine("Digite / para Dividir");
                Console.WriteLine("Digite ^ para potenciação");
                Console.WriteLine("Digite s para calcular o Seno");
                Console.WriteLine("Digite c para calcular o Cosseno");
                Console.WriteLine("Digite t para calcular a Tangente");
                Console.WriteLine("Digite h para calcular a Hipotenusa");
                Console.WriteLine("Digite r para ver os resultados armazenados");
                Console.WriteLine("--------------------------------------------------------------");
                operacao = char.ToUpper(char.Parse(Console.ReadLine()));
                double resultado = 0;

                switch (operacao)
                {
                    case '+':
                        Console.WriteLine("Digite o primeiro número da operação:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        num2 = double.Parse(Console.ReadLine());

                        resultado = Somar(num1, num2);
                        break;

                    case '-':
                        Console.WriteLine("Digite o primeiro número da operação:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        num2 = double.Parse(Console.ReadLine());

                        resultado = Subtrair(num1, num2);
                        break;

                    case '*':
                        Console.WriteLine("Digite o primeiro número da operação:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        num2 = double.Parse(Console.ReadLine());

                        resultado = Multiplicar(num1, num2);
                        break;

                    case '/':
                        Console.WriteLine("Digite o primeiro número da operação:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        num2 = double.Parse(Console.ReadLine());

                        resultado = Divisao(num1, num2);
                        break;

                    case '^':
                        Console.WriteLine("Digite o primeiro número da operação:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        num2 = double.Parse(Console.ReadLine());

                        resultado = Potencia(num1, num2);
                        break;

                    case 'S':
                        Console.WriteLine("Digite o cateto oposto:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a hipotenusa");
                        num2 = double.Parse(Console.ReadLine());

                        resultado = Seno(num1, num2);
                        break;

                    case 'C':
                        Console.WriteLine("Digite o cateto adjascente:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a hipotenusa");
                        num2 = double.Parse(Console.ReadLine());

                        resultado = Cosseno(num1, num2);
                        break;

                    case 'T':
                        Console.WriteLine("Digite o cateto oposto:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o cateto adjascente");
                        num2 = double.Parse(Console.ReadLine());

                        resultado = Tangente(num1, num2);
                        break;

                    case 'H':
                        Console.WriteLine("Digite o cateto oposto:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o cateto adjascente");
                        num2 = double.Parse(Console.ReadLine());

                        resultado = Hipotenusa(num1, num2);
                        break;

                    case 'R':
                       
                        Console.WriteLine("----- Histórico de Resultados -----");
                        for i = 0


                    default:
                        Console.WriteLine("Operação inválida!");
                        break;
                }

                if (operacao == '+' || operacao == '-' || operacao == '*' || operacao == '/' || operacao == 'p' || operacao == '^' || operacao == 'S' || operacao == 'C' || operacao == 'T' || operacao == 'H')
                {
                    MostrarResultado(resultado);
                }


                Console.WriteLine("Deseja fazer outra operação? Digite 'SIM' para continuar, se não, aperte qualquer TECLA para sair...");
                resposta = (Console.ReadLine().ToUpper());

                if (resposta != "SIM")
                {

                    continuar = false;
                    Console.WriteLine("Encerrando a calculadora.");

                }


                Console.WriteLine("--------------------------------------------");

            }

        }
    }
}