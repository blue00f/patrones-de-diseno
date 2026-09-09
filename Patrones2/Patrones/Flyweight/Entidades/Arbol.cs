namespace Flyweight.Entidades
{
    public class Arbol
    {
        public int X { get; set; }
        public int Y { get; set; }
        public TipoArbol Tipo { get; set; }
        public Arbol(int x, int y, TipoArbol tipo)
        {
            X = x;
            Y = x;
            Tipo = tipo;
        }
        public void Dibujar() => this.Tipo.Dibujar(X, Y);
    }
}
