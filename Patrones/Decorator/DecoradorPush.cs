namespace Decorator1
{
    internal class DecoradorPush : DecoradorNotificacion
    {
        public DecoradorPush(INotificacion notificacion) : base(notificacion) { }
        public override void Enviar(string mensaje)
        {
            notificacion.Enviar(mensaje);
            Console.WriteLine("Notificación Push enviada:");
            Console.WriteLine(mensaje);
        }
    }
}
