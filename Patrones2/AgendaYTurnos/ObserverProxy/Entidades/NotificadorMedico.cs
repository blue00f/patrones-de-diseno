namespace ObserverProxy.Entidades
{
    public class NotificadorMedico : IObservador
    {
        public void Actualizar(string mensaje)
        {
            Console.WriteLine("   [Agenda del medico] " + mensaje);
        }
    }
}
