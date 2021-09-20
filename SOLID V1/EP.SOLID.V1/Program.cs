using EP.SOLID.V1._2.OCP.OCP.Solucao_Extension_Methods;
using EP.SOLID.V1._3.LSP.LSP.VIOLACAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.SOLID.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("1 - OCP");
            Console.WriteLine("2 - LSP");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    CaixaEletronico.operacoes();
                    break;
                case '2':
                    CalculoArea.Calcular();
                    break;
            }
        }
    }
}
