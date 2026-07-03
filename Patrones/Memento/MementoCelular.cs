namespace Memento
{
    public class MementoCelular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public MementoCelular(string marca, string modelo, decimal precio)
        {
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
        }
    }
}
