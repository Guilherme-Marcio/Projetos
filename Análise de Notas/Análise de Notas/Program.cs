using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Análise_de_Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>() { 8.5, 6.0, 7.0, 9.5, 5.5, 10.0 };
            int aprovados = 0;
            double maior = notas[0];
            double menor = notas[0];

            foreach (double n in notas)
            {
                if (n >= 7) aprovados++;
                if (n > maior) maior = n;
                if (n < menor) menor = n;
            }

            Console.WriteLine("Notas >= 7: " + aprovados);
            Console.WriteLine("Maior nota: " + maior);
            Console.WriteLine("Menor nota: " + menor);
        }
    }
}
