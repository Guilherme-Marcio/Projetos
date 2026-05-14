using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Atendimento__Fila_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
            string opcao = "";

            while (opcao != "4")
            {
                Console.WriteLine("1 - Adicionar ");
                Console.WriteLine("2 - Atender ");
                Console.WriteLine("3 - Mostrar");
                Console.WriteLine("4 - Sair");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Write("Nome: ");
                    fila.Enqueue(Console.ReadLine());
                }
                else if (opcao == "2" && fila.Count > 0) Console.WriteLine("Atendido: " + fila.Dequeue());
                else if (opcao == "3") foreach (var c in fila) Console.WriteLine(c);
            }
        }
    }
}
