using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3.Entidades
{
    public class ClienteMayoristaCreator : ClienteCreator
    {
        public override CalculadoraDescuento CrearCalculadora() => new DescuentoClienteMayorista();
    }
}
