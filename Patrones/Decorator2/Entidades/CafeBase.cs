using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2.Entidades
{
    public class CafeBase : Bebida
    {
        public override string Descripcion => "Café";
        public override decimal Costo() => 800m;
    }
}
