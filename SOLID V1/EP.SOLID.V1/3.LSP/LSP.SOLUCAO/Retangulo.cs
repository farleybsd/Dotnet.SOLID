using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.SOLID.V1._3.LSP.LSP.SOLUCAO
{
    public class Retangulo : Paralelogramo
    {
        //As classes derivadas devem ser
        //substituíveis por suas classes bases.
        // Assim a regra fica na classe  Paralelogramo
        public Retangulo(int altura,int largura):base(altura,largura)
        {

        }
    }
}
