namespace AbstractFactory.Entidades
{
    public class TecladoGamer : ITeclado
    {
        public void MostrarInfo() => Console.WriteLine("Teclado Mecánico RGB - Switches Blue - $60.000");
    }
}
