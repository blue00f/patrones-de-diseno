namespace Decorator1
{
    public abstract class DecoradorNotificacion : INotificacion
    {
        protected INotificacion notificacion;
        public DecoradorNotificacion(INotificacion pNotificacion)
        {
            notificacion = pNotificacion;
        }
        public abstract void Enviar(string mensaje);
    }
}
