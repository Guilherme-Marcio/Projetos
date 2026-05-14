using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parênteses_Balanceados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expressao = "(a+(b*c))";
            Stack<char> p = new Stack<char>();
            bool valido = true;

            foreach (char c in expressao)
            {
                if (c == '(') p.Push(c);
                else if (c == ')')
                {
                    if (p.Count == 0) { valido = false; break; }
                    p.Pop();
                }
            }

            if (p.Count > 0) valido = false;
            Console.WriteLine(valido ? "Válido" : "Inválido");
        }
    }
}
