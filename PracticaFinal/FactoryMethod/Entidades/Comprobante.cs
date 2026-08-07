using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Entidades
{
    public abstract class Comprobante
    {
        public string Numero { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaEmision { get; set; }

        public abstract void Emitir();
    }
}
