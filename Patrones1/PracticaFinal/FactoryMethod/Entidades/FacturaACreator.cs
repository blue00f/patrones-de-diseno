using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Entidades
{
    public class FacturaACreator : ComprobanteCreator
    {
        public override Comprobante CrearComprobante()
        {
            return new FacturaA();
        }
    }
}
