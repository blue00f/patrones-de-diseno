namespace Observer.Entidades
{
    public class GestorPedido
    {
        List<IObservador> observadores;
        public Pedido Pedido { get; set; }
        public GestorPedido(Pedido pedido)
        {
            this.Pedido = pedido;
            observadores = new List<IObservador>();
        }

        public void Suscribir(IObservador o) => observadores.Add(o);
        public void Desuscribir(IObservador o) => observadores.Remove(o);
        private void Notificar()
        {
            foreach (IObservador o in observadores)
            {
                o.Actualizar(this.Pedido);
            }
        }
        public void ModificarEstado(Pedido pedido)
        {
            this.Pedido.Estado = pedido.Estado;
            Notificar();
        }
    }
}
