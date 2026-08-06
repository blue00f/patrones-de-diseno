using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2.Entidades
{
    public abstract class BebidaDecorator : Bebida
    {
        protected Bebida bebida;
        public BebidaDecorator(Bebida bebida)
        {
            this.bebida = bebida;
        }
    }
}
