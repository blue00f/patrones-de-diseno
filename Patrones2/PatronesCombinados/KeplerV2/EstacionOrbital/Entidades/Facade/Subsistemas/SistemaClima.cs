namespace EstacionOrbital.Entidades.Facade.Subsistemas
{
    public class SistemaClima
    {
        public void Regular() => Console.WriteLine("  [Clima] Temperatura en 21 °C.");
        public void Apagar() => Console.WriteLine("  [Clima] Climatización apagada.");
    }
}
