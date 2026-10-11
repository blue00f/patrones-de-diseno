namespace Mediator.Entidades
{
    public class Enfermeria : Colega
    {
        public Enfermeria(IMediator mediador) : base(mediador) { }
        public void ExtraerMuestra(string paciente) => Console.WriteLine($"[Enfermería] Extrae muestra a {paciente}");
        public void AdministrarMedicacion(string paciente) => Console.WriteLine($"[Enfermería] Administra la medicación a {paciente}");
    }
}
