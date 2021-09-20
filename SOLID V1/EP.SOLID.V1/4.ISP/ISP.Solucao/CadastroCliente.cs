using EP.SOLID.V1._4.ISP.ISP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.SOLID.V1._4.ISP.ISP.Solucao
{
    public class CadastroCliente : ICadastroCliente
    {
        public void EnviarEmail()
        {
            // Validar CPF, Email
        }

        public void SalvarBanco()
        {
            // Insert na tabela Cliente
        }

        public void ValidarDados()
        {
            // Enviar e-mail para o cliente
        }
    }
}
