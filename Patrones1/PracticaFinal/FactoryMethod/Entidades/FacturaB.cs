using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Entidades
{
    public class FacturaB : Comprobante
    {
        public string Dni { get; set; }
        public override void Emitir()
        {
            Console.WriteLine($"Factura B N°{this.Numero} - DNI: {this.Dni}\nTotal (IVA incluido): ${this.Monto:N2}");
        }
    }
}
