using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2.Entidades
{
    public class Leche : BebidaDecorator
    {
        public Leche(Bebida bebida) : base(bebida) { }
        public override string Descripcion => $"{bebida.Descripcion} + Leche";
        public override decimal Costo() => bebida.Costo() + 150m;
    }
}
