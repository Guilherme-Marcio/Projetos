using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Produtos_em_Estoque_Struct
{
    struct Produto
    {
        public string Nome;
        public double Preco;
        public int QuantidadeEstoque;

        public double CalcularValorTotal()
        {
            return Preco * QuantidadeEstoque;
        }
    }

    class Program
    {
        static void Main()
        {
            Produto[] produtos = new Produto[5];

            produtos[0] = new Produto { Nome = "Teclado Mecânico", Preco = 250.00, QuantidadeEstoque = 10 };
            produtos[1] = new Produto { Nome = "Mouse Gamer", Preco = 180.00, QuantidadeEstoque = 15 };
            produtos[2] = new Produto { Nome = "Monitor 144Hz", Preco = 1200.00, QuantidadeEstoque = 5 };
            produtos[3] = new Produto { Nome = "Headset USB", Preco = 350.00, QuantidadeEstoque = 8 };
            produtos[4] = new Produto { Nome = "Mousepad XL", Preco = 90.00, QuantidadeEstoque = 20 };

            Produto produtoMaisCaro = produtos[0];

            Console.WriteLine("--- LISTA DE PRODUTOS ---");
            foreach (Produto p in produtos)
            {
                double valorTotalEstoque = p.CalcularValorTotal();
                Console.WriteLine($"Produto: {p.Nome} | Preço: R$ {p.Preco:F2} | Qtd: {p.QuantidadeEstoque} | Total em Estoque: R$ {valorTotalEstoque:F2}");

                if (p.Preco > produtoMaisCaro.Preco)
                {
                    produtoMaisCaro = p;
                }
            }

            Console.WriteLine("--- PRODUTO MAIS CARO ---");
            Console.WriteLine($"O produto mais caro é: {produtoMaisCaro.Nome} (R$ {produtoMaisCaro.Preco:F2})");
        }
    }
}
