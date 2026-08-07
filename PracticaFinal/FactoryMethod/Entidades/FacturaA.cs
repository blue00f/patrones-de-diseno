using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Entidades
{
    public class FacturaA : Comprobante
    {
        public decimal MontoNeto { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal MontoIva => MontoNeto * PorcentajeIva / 100;
        public override void Emitir()
        {
            Console.WriteLine($"Factura A N°{this.Numero}\nNeto: {this.MontoNeto} + IVA {this.PorcentajeIva}%: ${this.MontoIva:N2} = Total: ${this.Monto}");
        }
    }
}
