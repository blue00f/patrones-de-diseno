namespace Composite1.Entidades
{
    public interface IElemento
    {
        string Nombre { get; }
        int ObtenerTamanio();
        void Mostrar();
    }
}
