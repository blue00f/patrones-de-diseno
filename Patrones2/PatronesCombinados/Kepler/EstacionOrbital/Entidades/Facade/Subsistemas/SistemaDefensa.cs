namespace EstacionOrbital.Entidades.Facade.Subsistemas
{
    public class SistemaDefensa
    {
        public void Standby() => Console.WriteLine("  [Defensa] Escudos en standby.");
        public void ActivarEscudos() => Console.WriteLine("  [Defensa] ¡Escudos al 100%!");
        public void Desactivar() => Console.WriteLine("  [Defensa] Defensas desactivadas.");
    }
}
