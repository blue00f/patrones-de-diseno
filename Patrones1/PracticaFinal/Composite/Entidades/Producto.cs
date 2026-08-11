namespace Composite.Entidades
{
    public class Producto : IElemento
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal CalcularTotal() => this.Precio;
        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
