namespace Composite.Entidades
{
    public interface IElemento
    {
        string Nombre { get; }
        decimal CalcularTotal();
    }
}
