using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Alarma : IObservador
    {
        public void Actualizar(string color)
        {
            Console.WriteLine($"Alamar detectó color {color}");
        }
    }
}
