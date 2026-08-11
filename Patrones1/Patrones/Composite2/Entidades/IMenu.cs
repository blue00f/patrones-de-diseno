namespace Composite2.Entidades
{
    public interface IMenu
    {
        public string Nombre { get; set; }
        decimal ObtenerPrecio();
        void Mostrar(int nivel = 0);
    }
}
