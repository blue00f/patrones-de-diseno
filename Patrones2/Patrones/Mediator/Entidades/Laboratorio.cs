namespace Mediator.Entidades
{
    public class Laboratorio : Colega
    {
        public Laboratorio(IMediator mediador) : base(mediador) { }
        public void RealizarEstudio(string paciente) => Console.WriteLine($"[Laboratorio] Procesando muestra de {paciente}...");
        public void EntregarResultado(string paciente)
        {
            Console.WriteLine($"[Laboratorio] Resultado de {paciente} listo");
            mediador.Notificar(this, Evento.ResultadoListo, paciente);
        }
    }
}
