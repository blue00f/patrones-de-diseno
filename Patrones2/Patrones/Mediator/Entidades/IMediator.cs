namespace Mediator.Entidades
{
    public interface IMediator
    {
        void Notificar(Colega emisor, Evento evento, string paciente);
    }
}
