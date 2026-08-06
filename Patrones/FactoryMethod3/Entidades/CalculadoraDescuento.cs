using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3.Entidades
{
    public abstract class CalculadoraDescuento
    {
        public abstract decimal ObtenerPorcentaje();
        public decimal AplicarDescuento(decimal montoOriginal)
        {
            decimal porcentaje = ObtenerPorcentaje();
            decimal descuento = montoOriginal * (porcentaje / 100);
            decimal montoFinal = montoOriginal - descuento;

            Console.WriteLine($"Monto original: ${montoOriginal:N2}\nDescuento aplicado: ${descuento:N2}\nMonto final: ${montoFinal:N2}\n");
            return montoFinal;
        }
    }
}
