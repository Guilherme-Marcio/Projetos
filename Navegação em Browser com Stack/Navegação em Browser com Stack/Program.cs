using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navegação_em_Browser_com_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> historicoVoltar = new Stack<string>();
            Stack<string> historicoAvancar = new Stack<string>();
            string paginaAtual = "google.com";

            historicoVoltar.Push(paginaAtual);
            paginaAtual = "github.com";

            Console.WriteLine("Página atual: " + paginaAtual);

            if (historicoVoltar.Count > 0)
            {
                historicoAvancar.Push(paginaAtual);
                paginaAtual = historicoVoltar.Pop();
                Console.WriteLine("Voltou para: " + paginaAtual);
            }
        }
    }
}
