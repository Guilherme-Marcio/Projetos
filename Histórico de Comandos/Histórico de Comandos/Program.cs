using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histórico_de_Comandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> comandos = new Stack<string>();
            comandos.Push("git add .");
            comandos.Push("git commit");
            comandos.Push("git push");

            Console.WriteLine("Desfazendo: " + comandos.Pop());
            foreach (var cmd in comandos) Console.WriteLine("No histórico: " + cmd);
        }
    }
}
