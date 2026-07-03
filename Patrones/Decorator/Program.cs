using Decorator;

class Program
{
    static void Main(string[] args)
    {
        INotificacion notificacion = new NotificacionEmail();
        notificacion.Enviar("Enviando pedido");

        Console.WriteLine();
        notificacion = new DecoradorPush(notificacion);
        notificacion.Enviar("Enviando pedido");
    }
}