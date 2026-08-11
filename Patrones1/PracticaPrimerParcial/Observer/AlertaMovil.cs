using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class AlertaMovil : ISuscriptor
    {
        public string Nombre { get; set; }
        public AlertaMovil(string nombre)
        {
            Nombre = nombre;
        }
        public void Actualizar(decimal temperatura)
        {
            Console.WriteLine($"Mostrando temperatura {temperatura} en el móvil {this.Nombre}");
        }
    }
}
