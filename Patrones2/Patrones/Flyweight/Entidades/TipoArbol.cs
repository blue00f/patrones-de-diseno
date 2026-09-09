namespace Flyweight.Entidades
{
    public class TipoArbol // Flywegight -> Con propiedades intrínsecas del árbol
    {
        public string Nombre { get; }
        public string Color { get;  }
        public string Textura { get; }
        public TipoArbol(string nombre, string color, string textura)
        {
            Nombre = nombre;
            Color = color;
            Textura = textura;
        }
        public void Dibujar(int x, int y)
        {
            Console.WriteLine($"Dibujando {Nombre} [{Color}] en la posición ({x}, {y})");
        }
    }
}
