using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3.Entidades
{
    public abstract class ClienteCreator
    {
        public abstract CalculadoraDescuento CrearCalculadora();
        public decimal ProcesarCompra(decimal montoOriginal)
        {
            CalculadoraDescuento calculadora = CrearCalculadora();
            return calculadora.AplicarDescuento(montoOriginal);
        }
    }
}
