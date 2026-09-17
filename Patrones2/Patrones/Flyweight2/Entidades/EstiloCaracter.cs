namespace Flyweight2.Entidades
{
    public class EstiloCaracter
    {
        public string Fuente { get; }
        public int Tamanio { get; }
        public string Color { get; }
        public bool Negrita { get; }
        public EstiloCaracter(string fuente, int tamanio, string color, bool negrita)
        {
            Fuente = fuente;
            Tamanio = tamanio;
            Color = color;
            Negrita = negrita;
            Console.WriteLine($"\t>> Estilo creado en memoria: {Fuente} {Tamanio}pt {Color} {(Negrita ? "Negrita" : "Normal")}");
        }
    }
}
