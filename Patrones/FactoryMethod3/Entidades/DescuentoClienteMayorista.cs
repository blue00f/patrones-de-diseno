using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3.Entidades
{
    public class DescuentoClienteMayorista : CalculadoraDescuento
    {
        public override decimal ObtenerPorcentaje() => 25m;
    }
}
