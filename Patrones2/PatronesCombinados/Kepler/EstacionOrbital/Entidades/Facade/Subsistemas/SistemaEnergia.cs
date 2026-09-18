namespace EstacionOrbital.Entidades.Facade.Subsistemas
{
    public class SistemaEnergia
    {
        public void Encender() => Console.WriteLine("  [Energía] Reactor principal en línea.");
        public void ModoReserva() => Console.WriteLine("  [Energía] Cambiando a energía de reserva.");
        public void Apagar() => Console.WriteLine("  [Energía] Reactor apagado.");
    }
}
