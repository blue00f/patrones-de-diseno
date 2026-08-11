using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Entidades
{
    public class NotaCredito : Comprobante
    {
        public string NumeroComprobanteAsociado { get; set; }
        public string Motivo { get; set; }
        public override void Emitir()
        {
            Console.WriteLine($"Nota de crédito N°{this.Numero} - Anula comprobante: {this.NumeroComprobanteAsociado}\nMotivo: {this.Motivo} | Monto: {this.Monto:N2}");
        }
    }
}
