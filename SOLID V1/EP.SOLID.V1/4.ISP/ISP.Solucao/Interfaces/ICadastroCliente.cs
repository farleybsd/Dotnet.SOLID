using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.SOLID.V1._4.ISP.ISP.Solucao.Interfaces
{
    public interface ICadastroCliente
    {
        void ValidarDados();
        void SalvarBanco();
        void EnviarEmail();

    }
}
