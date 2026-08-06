using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2.Entidades
{
    public abstract class Bebida
    {
        public abstract string Descripcion { get; }
        public abstract decimal Costo();
    }
}
