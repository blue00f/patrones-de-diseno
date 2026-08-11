using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Entidades
{
    public class MostradorObserver : IObservador
    {
        public int NumMostrador { get; set; }
        public MostradorObserver(int numMostrador)
        {
            NumMostrador = numMostrador;
        }
        public void Actualizar(Pedido pedido)
        {
            Console.WriteLine($"---Mostrador: pedido programado listo para retirar por {pedido.NombreCliente}");
        }
    }
}
