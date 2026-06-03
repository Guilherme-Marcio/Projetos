using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Carros_com_Struct
{
  
        struct Carro
        {
            public string Modelo;
            public string Marca;
            public int Ano;
            public double Preco;

            public void ExibirDados()
            {
                Console.WriteLine($"Marca: {Marca} | Modelo: {Modelo} | Ano: {Ano} | Preço: R$ {Preco:F2}");
            }
        }

        class Program
        {
            static void Main()
            {
                Carro carro1;
                carro1.Modelo = "Onix";
                carro1.Marca = "Chevrolet";
                carro1.Ano = 2022;
                carro1.Preco = 75000.00;

                Carro carro2;
                carro2.Modelo = "Corolla";
                carro2.Marca = "Toyota";
                carro2.Ano = 2023;
                carro2.Preco = 145000.00;

                carro1.ExibirDados();
                carro2.ExibirDados();
            }
        }
    }

