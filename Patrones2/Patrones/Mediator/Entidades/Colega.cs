namespace Mediator.Entidades
{
    public abstract class Colega
    {
        protected IMediator mediador;
        protected Colega(IMediator mediador)
        {
            this.mediador = mediador;
        }
    }
}
