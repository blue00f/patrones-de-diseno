namespace Mediator.Entidades
{
    public class Medico : Colega
    {
        public Medico(IMediator mediator) : base(mediator) { }
        public void SolicitarEstudio(string paciente)
        {
            Console.WriteLine($"[Médico] Solicita un estudio para {paciente}");
            mediador.Notificar(this, Evento.EstudioSolicitado, paciente);
        }
        public void IndicarMedicacion(string paciente)
        {
            Console.WriteLine($"[Médico] Indica medicación para {paciente}");
            mediador.Notificar(this, Evento.MedicacionIndicada, paciente);
        }
        public void RecibirResultado(string paciente) => Console.WriteLine($"[Médico] Recibe el resultado del estudio de {paciente}");
    }
}
