using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.SOLID.V1._2.OCP.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // Logica de negócio para debito em conta investimento.
            return debitoConta.FormatarTransacao();
        }
    }
}
