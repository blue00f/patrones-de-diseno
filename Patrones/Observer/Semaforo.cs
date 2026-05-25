using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Observer
{
    internal class Semaforo
    {
        List<IObservador> observadores;
        string _color;
        public Semaforo()
        {
            observadores = new List<IObservador>();
        }
        public void Suscribir(IObservador observador)
        {
            var obs = observadores.Find(x => x == observador);
            if (obs == null)
            {
                observadores.Add(observador);
            }
        }
        public void Desuscribir(IObservador observador)
        {
            var obs = observadores.Find(x => x == observador);
            if (obs != null)
            {
                observadores.Remove(observador);
            }
        }
        private void Notificar()
        {
            foreach(IObservador o in observadores)
            {
                o.Actualizar(_color);
            }
        }
        public void CambiarColor(string nuevoColor)
        {
            _color = nuevoColor;
            Console.WriteLine($"El semáforo cambió a {_color}");
            Notificar();
        }
    }
}
