namespace Decorator1.Entidades
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
