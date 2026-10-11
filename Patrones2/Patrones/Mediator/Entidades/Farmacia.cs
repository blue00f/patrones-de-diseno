namespace Mediator.Entidades
{
    public class Farmacia : Colega
    {
        public Farmacia(IMediator mediador) : base(mediador) { }
        public void PrepararMedicacion(string paciente) => Console.WriteLine($"[Farmacia] Prepara la medicación de {paciente}");
    }
}
