namespace EstacionOrbital.Entidades.Facade.Subsistemas
{
    public class SistemaNavegacion
    {
        public void CalibrarOrbita() => Console.WriteLine("  [Navegación] Órbita calibrada.");
        public void Estabilizar() => Console.WriteLine("  [Navegación] Estabilizando la estación.");
        public void Apagar() => Console.WriteLine("  [Navegación] Propulsores desactivados.");
    }
}
