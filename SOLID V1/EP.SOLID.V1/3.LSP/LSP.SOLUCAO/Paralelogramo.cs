using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.SOLID.V1._3.LSP.LSP.SOLUCAO
{
    public abstract class Paralelogramo
    {
        protected Paralelogramo(int altura,int largura)
        {
            Altura = altura;
            Largura = largura;
        }
        public double Altura { get; private set; }
        public double Largura { get; set; }
        public double Area { get {return Altura * Largura; } }
    }
}
