namespace EstacionOrbital.Entidades.Bridge
{
    public class MensajeEmergencia : Mensaje
    {
        public MensajeEmergencia(ICifrado cifrado, string contenido) : base(cifrado, contenido) { }
        protected override string Tipo => "MENSAJE DE EMERGENCIA";
        protected override string Prioridad => "MÁXIMA";
    }
}
