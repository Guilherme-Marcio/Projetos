using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Cadastro_de_Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> produtos = new List<string>();
            int opcao;

            do
            {
                Console.WriteLine("1-Adicionar | 2-Remover | 3-Listar | 0-Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Produto: ");
                        produtos.Add(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Nome para remover: ");
                        produtos.Remove(Console.ReadLine());
                        break;
                    case 3:
                        foreach (string p in produtos) Console.WriteLine("- " + p);
                        break;
                }
            } while (opcao != 0);
        }
    }
}
