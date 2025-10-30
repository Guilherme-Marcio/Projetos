using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Temperatura
{
    internal class Program
    {

        static double CelsiusPaFah(double a)
        {
            return (a * 1.8) + 32;
        }

        static double FahPaCelsius(double a)
        {
            return (a - 32) / 1.8;
        }

        static double CelsiusPaKelvin(double a)
        {

            return a + 273.15;
        }



        static void Main(string[] args)
        {
            double temp;
            string op = "SIM";

            Console.WriteLine("------------- Conversor de Temperatura -------------");
            Console.WriteLine("Escolha seu método de conversão:");
            Console.WriteLine("Digite '1' para converter de Celsius para Fahrenheit.");
            Console.WriteLine("Digite '2' para converter de Fahrenheit para Celsius.");
            Console.WriteLine("Digite '3' para converter de Celsius para Kelvin.");
            Console.WriteLine("Digite '4' para sair do conversor...");
            int resp = int.Parse(Console.ReadLine());

            switch (resp)
            {
                case 1:
                    Console.WriteLine("Digite a temperatura em C°:");
                    temp = double.Parse(Console.ReadLine());

                    Console.WriteLine($"A temperatura em Fahrenheit é {CelsiusPaFah(temp)}");
                    break;

                case 2:
                    Console.WriteLine("Digite a temperatura em F°");
                    temp = double.Parse(Console.ReadLine());

                    Console.WriteLine($"A temperatura em Celsius é {FahPaCelsius(temp)}");
                    break;

                case 3:
                    Console.WriteLine("Digite a temperatura em C°");
                    temp = double.Parse(Console.ReadLine());

                    Console.WriteLine($"A temperatura em Kelvin é {CelsiusPaKelvin(temp)}");
                    break;

                case 4:
                    Console.WriteLine("Aperte enter para encerrar o conversor");
                    break;

                default:
                    Console.WriteLine("Erro! Digite um número válido para o tipo de conversão.");
                    break;
            }


        }
    }
}