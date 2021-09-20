using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.SOLID.V1._2.OCP.OCP.VIOLACAO
{
    public class DebitoConta
    {
        public void Debitar(decimal valor,string conta, TipoConta tipoConta)
        {
            // Todos esses if de tipo de conta sera subistituido por uma classe especifica
            // Para cada Tipo De conta que herdara de uma classe abstract DebitoConta
            if (tipoConta == TipoConta.Corrente) // Errado
            {
                // Debita Conta Corrente
            }

            if (tipoConta == TipoConta.Poupanca) // Errado
            {
                // Valida Aniversário da Conta
                // Debita Conta Poupança
            }
        }
    }
}
