namespace Decorator1
{
    public class NotificacionEmail : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine("Email enviado:");
            Console.WriteLine(mensaje);
        }
    }
}
