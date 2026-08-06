using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3.Entidades
{
    public class DescuentoClienteVip : CalculadoraDescuento
    {
        public override decimal ObtenerPorcentaje() => 15m;
    }
}
