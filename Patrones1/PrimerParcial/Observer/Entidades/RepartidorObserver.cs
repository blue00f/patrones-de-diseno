using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Entidades
{
    public class RepartidorObserver : IObservador
    {
        public string Nombre { get; set; }
        public RepartidorObserver(string nombre)
        {
            Nombre = nombre;
        }
        public void Actualizar(Pedido pedido)
        {
            Console.WriteLine($"---{this.Nombre}: nuevo pedido para entregar en {pedido.Direccion}");
        }
    }
}
