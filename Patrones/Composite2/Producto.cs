using System;
using System.Collections.Generic;
using System.Text;

namespace Composite2
{
    public class Producto : IMenu
    {
        public string Nombre { get; set; }
        private decimal _precio;
        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            _precio = precio;
        }

        public void Mostrar(int nivel = 0) => Console.WriteLine($"{new string(' ', nivel * 3)}Producto: {Nombre} - ${_precio}");
        public decimal ObtenerPrecio() => _precio;
    }
}
