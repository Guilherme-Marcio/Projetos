using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histórico_de_Ações_com_Stack__struct_
{
    struct AcaoEditor
    {
        public string Descricao;
        public DateTime DataHora;
    }
    class Program
    {
        static void Main()
        {
            Stack<AcaoEditor> historico = new Stack<AcaoEditor>();

            historico.Push(new AcaoEditor { Descricao = "Digitou texto", DataHora = DateTime.Now });
            historico.Push(new AcaoEditor { Descricao = "Apagou parágrafo", DataHora = DateTime.Now });
            historico.Push(new AcaoEditor { Descricao = "Alterou título", DataHora = DateTime.Now });

            AcaoEditor acaoDesfeita = historico.Pop();

            Console.WriteLine("--- AÇÃO DESFEITA ---");
            Console.WriteLine($"Ação: {acaoDesfeita.Descricao} realizada em {acaoDesfeita.DataHora}");
        }
    }
}
