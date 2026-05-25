using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Entidades
{
    public class GestorPedidosProgramados
    {
        List<IObservador> observadores;
        public Pedido Pedido { get; set; }
        public GestorPedidosProgramados()
        {
            observadores = new List<IObservador>();
        }
        public void Suscribir(IObservador obs)
        {
            var obj = observadores.Find(x => x == obs);
            if (obj == null)
            {
                observadores.Add(obs);
            }
        }
        public void Desuscribir(IObservador obs) => observadores.Remove(obs);
        private void Notificar()
        {
            foreach(IObservador o in observadores)
            {
                o.Actualizar(this.Pedido);
            }
        }
        public void AgregarPedido(Pedido pedido)
        {
            Pedido = pedido;
            Notificar();
        }
    }
}
