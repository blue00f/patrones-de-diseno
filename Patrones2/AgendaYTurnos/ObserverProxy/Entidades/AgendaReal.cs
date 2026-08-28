namespace ObserverProxy.Entidades
{
    public class AgendaReal : IAgenda
    {
        private readonly List<IObservador> _observadores;
        public AgendaReal()
        {
            _observadores = new List<IObservador>();
        }
        public void Suscribir(IObservador observador)
        {
            _observadores.Add(observador);
        }
        public void ReservarTurno(string rol, string paciente)
        {
            Console.WriteLine("Turno reservado para " + paciente + ".");
            Notificar("Se reservo un turno para " + paciente + ".");
        }
        private void Notificar(string mensaje)
        {
            foreach (var observador in _observadores)
            {
                observador.Actualizar(mensaje);
            }
        }
    }
}
