using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Atendimento_Hospitalar_com_Queue__struct_
{
    struct Paciente
    {
        public string Nome;
        public int Idade;
        public int NumeroSenha;
    }
    class Program
    {
        static void Main()
        {
            Queue<Paciente> filaHospital = new Queue<Paciente>();

            filaHospital.Enqueue(new Paciente { Nome = "Marcos Silva", Idade = 34, NumeroSenha = 101 });
            filaHospital.Enqueue(new Paciente { Nome = "Ana Souza", Idade = 22, NumeroSenha = 102 });
            filaHospital.Enqueue(new Paciente { Nome = "Roberto Costa", Idade = 65, NumeroSenha = 103 });
            filaHospital.Enqueue(new Paciente { Nome = "Juliana Reis", Idade = 19, NumeroSenha = 104 });

            Console.WriteLine("--- PACIENTES ATENDIDOS ---");

            Paciente atendido1 = filaHospital.Dequeue();
            Console.WriteLine($"Senha {atendido1.NumeroSenha}: {atendido1.Nome} ({atendido1.Idade} anos)");

            Paciente atendido2 = filaHospital.Dequeue();
            Console.WriteLine($"Senha {atendido2.NumeroSenha}: {atendido2.Nome} ({atendido2.Idade} anos)");

            Console.WriteLine("--- PACIENTES AGUARDANDO NA FILA ---");
            foreach (Paciente p in filaHospital)
            {
                Console.WriteLine($"Senha {p.NumeroSenha}: {p.Nome} ({p.Idade} anos)");
            }

            Console.WriteLine($"Quantidade de pacientes que ainda aguardam: {filaHospital.Count}");
        }
    }
}
