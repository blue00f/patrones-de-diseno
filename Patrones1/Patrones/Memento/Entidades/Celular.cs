namespace Memento.Entidades
{
    public class Celular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public Celular(string marca, string modelo, decimal precio)
        {
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
        }
        public MementoCelular CrearMemento()
        {
            return new MementoCelular(Marca, Modelo, Precio);
        }
        public void Restaurar(MementoCelular memento)
        {
            Marca = memento.Marca;
            Modelo = memento.Modelo;
            Precio = memento.Precio;
        }
        public override string ToString() => $"Marca: {this.Marca}\nModelo: {this.Modelo}\nPrecio: {this.Precio}\n";
    }
}
