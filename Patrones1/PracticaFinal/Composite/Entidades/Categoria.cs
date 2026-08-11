namespace Composite.Entidades
{
    public class Categoria : IElemento
    {
        public string Nombre { get; set; }
        List<IElemento> elementos;
        public Categoria(string nombre)
        {
            Nombre = nombre;
            elementos = new List<IElemento>();
        }
        public void Agregar(IElemento e) => elementos.Add(e);
        public void Borrar(IElemento e) => elementos.Remove(e);
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (IElemento e in elementos)
            {
                total += e.CalcularTotal();
            }
            return total;
        }
    }
}
