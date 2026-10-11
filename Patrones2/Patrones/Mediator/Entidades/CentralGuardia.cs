namespace Mediator.Entidades
{
    public class CentralGuardia : IMediator
    {
        public Medico Medico { get; set; }
        public Laboratorio Laboratorio { get; set; }
        public Farmacia Farmacia { get; set; }
        public Enfermeria Enfermeria { get; set; }
        public void Notificar(Colega emisor, Evento evento, string paciente)
        {
            switch (evento)
            {
                case Evento.EstudioSolicitado:
                    this.Enfermeria.ExtraerMuestra(paciente);
                    this.Laboratorio.RealizarEstudio(paciente);
                    break;

                case Evento.ResultadoListo:
                    this.Medico.RecibirResultado(paciente);
                    break;

                case Evento.MedicacionIndicada:
                    this.Farmacia.PrepararMedicacion(paciente);
                    this.Enfermeria.AdministrarMedicacion(paciente);
                    break;
            }
        }
    }
}
