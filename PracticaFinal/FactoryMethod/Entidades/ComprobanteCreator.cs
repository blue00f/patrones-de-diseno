using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Entidades
{
    public abstract class ComprobanteCreator
    {
        public abstract Comprobante CrearComprobante();
    }
}
