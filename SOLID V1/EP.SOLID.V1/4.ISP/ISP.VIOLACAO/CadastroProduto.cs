using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.SOLID.V1._4.ISP.ISP.VIOLACAO
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            // Validar valor
        }

        public void SalvarBanco()
        {
            // Insert tabela Produto
        }

        public void ValidarDados()
        {
            // Produto não tem e-mail, o que eu faço agora???
            throw new NotImplementedException("Esse metodo não serve pra nada");
        }
    }
}
