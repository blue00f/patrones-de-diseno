namespace EstacionOrbital.Entidades.Facade.Subsistemas
{
    public class SistemaSeguridad
    {
        public void Armar() => Console.WriteLine("  [Seguridad] Sensores y puertas activos.");
        public void SellarCompuertas() => Console.WriteLine("  [Seguridad] Compuertas selladas.");
        public void Bloquear() => Console.WriteLine("  [Seguridad] Estación bloqueada.");
    }
}
