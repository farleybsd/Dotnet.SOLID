﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.SOLID.V1._3.LSP.LSP.VIOLACAO
{
    public class Retangulo
    {
        public virtual  double Altura { get; set; }
        public virtual double Largura { get; set; }
        public double Area { get { return Altura * Largura; } }
    }
}
