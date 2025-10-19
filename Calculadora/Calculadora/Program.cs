using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static double Somar(double a , double b)
        {
            return a + b;
        }

        static double Subtrair(double a , double b)
        {
            return a - b;
        }

        static double Multiplicar(double a , double b)
        {
            return a * b;
        }

        static double Divisao(double a , double b)
        {
            if (b == 0) {

                Console.WriteLine("Divisão por 0 não é permitida");
                return 0;
                 
            }
                
           
            return a / b;
        }
        
        static double Potencia(double a, double b)
        {
            return Math.Pow(a, b);
        }

        static void MostrarResultado(double resultado)
        { 
            Console.WriteLine($"O resultado é: {resultado}");
        }

        static void Main(string[] args)
        {
            char operacao, resposta;
            double num1, num2;
            bool continuar = true;

            Console.WriteLine(" CALCULADORA EM C#");
            Console.WriteLine("--------------------");
           
            while (continuar)
            {
                Console.WriteLine("Digite o primeiro número da operação:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número da operação");
                num2 = double.Parse(Console.ReadLine());
             
                Console.WriteLine("Escolha a operação que você deseja fazer:");
                Console.WriteLine("Digite + para Somar");
                Console.WriteLine("Digite - para Subtrair");
                Console.WriteLine("Digite * para Multiplicar");
                Console.WriteLine("Digite / para Dividir");
                Console.WriteLine("Digite p para potenciação");
                operacao = char.Parse(Console.ReadLine());
                double resultado = 0;

                switch (operacao)
                {
                    case '+':
                        resultado = Somar(num1, num2);
                        break;

                    case '-':
                        resultado = Subtrair(num1, num2);
                        break;

                    case '*':
                        resultado = Multiplicar(num1, num2);
                        break;

                    case '/':
                        resultado = Divisao(num1, num2);
                        break;

                    case 'p':
                        resultado = Potencia(num1, num2);
                        break;

                    default:
                        Console.WriteLine("Operação inválida!");
                        break;
                }

                if (operacao == '+' || operacao == '-' || operacao == '*' || operacao == '/' || operacao == 'p')
                {
                    MostrarResultado(resultado);
                }



                Console.WriteLine("Deseja fazer outra operação? Digite 'S' para continuar, se não, aperte ENTER para sair...");
                resposta = char.Parse(Console.ReadLine());
                resposta = char.ToUpper(resposta);
                Console.Clear();

                if (resposta != 'S')
                {

                    continuar = false;
                    Console.WriteLine("Encerrando a calculadora.");

                }


                Console.WriteLine("--------------------------------------------");

            }















        }
            }
}
