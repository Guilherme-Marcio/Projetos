using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Desfazer__Undo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> acoes = new Stack<string>();
            acoes.Push("Digitar texto");
            acoes.Push("Inserir imagem");
            acoes.Push("Mudar cor");

            Console.WriteLine("Última ação: " + acoes.Peek());
            Console.WriteLine("Desfazendo: " + acoes.Pop());
            Console.WriteLine("Nova última ação: " + acoes.Peek());
        }
    }
}
