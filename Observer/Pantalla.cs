using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Pantalla : IObservador
    {
        public string Nombre { get; set; }
        public Pantalla(string nombre)
        {
            Nombre = nombre;
        }
        public void Actualizar(string color)
        {
            Console.WriteLine($"{this.Nombre} muestra el color {color}");
        }
    }
}
