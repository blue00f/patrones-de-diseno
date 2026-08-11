namespace AbstractFactory.Entidades
{
    public class TecladoOficina : ITeclado
    {
        public void MostrarInfo() => Console.WriteLine("Teclado de Membrana Ergonómico - $18.000");
    }
}
