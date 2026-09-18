namespace EstacionOrbital.Entidades.Facade.Subsistemas
{
    public class SistemaComunicaciones
    {
        public void Conectar() => Console.WriteLine("  [Comunicaciones] Enlace con la Tierra establecido.");
        public void EnviarSOS() => Console.WriteLine("  [Comunicaciones] Señal SOS enviada.");
        public void Desconectar() => Console.WriteLine("  [Comunicaciones] Enlace cerrado.");
    }
}
