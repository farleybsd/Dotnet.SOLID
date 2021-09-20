using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.SOLID.V1._4.ISP.ISP.VIOLACAO
{
    public class CadastroCliente : ICadastro
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
