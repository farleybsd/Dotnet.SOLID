using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.SOLID.V1._3.LSP.LSP.VIOLACAO
{
    public class Quadrado : Retangulo
    {
        //Errado
        public override double Altura 
        { 
            get => base.Altura; set => base.Altura = value;
        }

        //Errado
        public override double Largura 
        { 
            get => base.Largura; set => base.Largura = value; 
        }
    }
}
