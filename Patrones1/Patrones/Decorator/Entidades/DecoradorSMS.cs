namespace Decorator1.Entidades
{
    public class DecoradorSMS : DecoradorNotificacion
    {
        public DecoradorSMS(INotificacion notificacion) : base(notificacion) { }
        public override void Enviar(string mensaje)
        {
            notificacion.Enviar(mensaje);
            Console.WriteLine("SMS enviado:");
            Console.WriteLine(mensaje);
        }
    }
}
