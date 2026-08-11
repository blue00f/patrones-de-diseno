namespace Observer.Entidades
{
    public class Alarma : IObservador
    {
        public void Actualizar(string color)
        {
            Console.WriteLine($"Alamar detectó color {color}");
        }
    }
}
