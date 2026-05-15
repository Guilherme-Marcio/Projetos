using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_e_Média_de_Valores_com_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numeros = new List<double>() { 10.5, 20.0, 30.5, 40.0 };
            double soma = 0;

            foreach (double n in numeros)
            {
                soma += n;
            }

            double media = soma / numeros.Count;

            Console.WriteLine("Soma total: " + soma);
            Console.WriteLine("Média: " + media);
        }
    }
}
