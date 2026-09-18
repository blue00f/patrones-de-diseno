namespace EstacionOrbital.Entidades.Facade.Subsistemas
{
    public class SistemaLog
    {
        public void Registrar(string evento) => Console.WriteLine($"  [Log] {DateTime.Now:HH:mm:ss} - {evento}");
    }
}
