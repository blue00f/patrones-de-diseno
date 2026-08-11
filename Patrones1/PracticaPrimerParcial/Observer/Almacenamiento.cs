using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Almacenamiento : ISuscriptor
    {
        public int Espacio { get; set; }
        public Almacenamiento(int espacio)
        {
            Espacio = espacio;
        }
        public void Actualizar(decimal temperatura)
        {
            Console.WriteLine($"Mostrando temperatura {temperatura} en el servidor con espacio {this.Espacio}GiB");
        }
    }
}
