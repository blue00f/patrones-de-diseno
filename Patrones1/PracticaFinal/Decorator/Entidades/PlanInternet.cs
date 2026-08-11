namespace Decorator.Entidades
{
    public abstract class PlanInternet
    {
        public abstract string Descripcion { get; }
        public abstract decimal CalcularCosto();
    }
}
