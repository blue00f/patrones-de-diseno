using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3.Entidades
{
    public class ClienteRegularCreator : ClienteCreator
    {
        public override CalculadoraDescuento CrearCalculadora() => new DescuentoClienteRegular();
    }
}
