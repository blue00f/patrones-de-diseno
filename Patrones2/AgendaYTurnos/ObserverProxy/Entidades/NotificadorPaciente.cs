namespace ObserverProxy.Entidades
{
    public class NotificadorPaciente : IObservador
    {
        public void Actualizar(string mensaje)
        {
            Console.WriteLine("   [SMS al paciente] " + mensaje);
        }
    }
}
