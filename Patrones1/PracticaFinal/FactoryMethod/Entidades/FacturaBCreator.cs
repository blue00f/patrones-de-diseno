using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Entidades
{
    public class FacturaBCreator : ComprobanteCreator
    {
        public override Comprobante CrearComprobante()
        {
            return new FacturaB();
        }
    }
}
