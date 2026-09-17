namespace Flyweight2.Entidades
{
    public class CaracterDocumento
    {
        public char Letra { get; }
        public int Posicion { get; }
        private EstiloCaracter estilo;
        public CaracterDocumento(char letra, int posicion, EstiloCaracter estilo)
        {
            Letra = letra;
            Posicion = posicion;
            this.estilo = estilo;
        }
        public void Renderizar()
        {
            string negrita = estilo.Negrita ? "**" : "";
            Console.Write($"{negrita}{Letra}{negrita}");
        }
    }
}
