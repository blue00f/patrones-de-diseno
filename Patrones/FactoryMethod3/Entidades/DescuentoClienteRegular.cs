using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3.Entidades
{
    public class DescuentoClienteRegular : CalculadoraDescuento
    {
        public override decimal ObtenerPorcentaje() => 0m;
    }
}
