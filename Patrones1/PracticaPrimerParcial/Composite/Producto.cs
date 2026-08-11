using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Producto : IComponente
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
        public void Mostrar() => Console.WriteLine($"{this.Precio}-{this.Nombre}");

        public decimal CalcularTotal() => this.Precio;
    }
}
