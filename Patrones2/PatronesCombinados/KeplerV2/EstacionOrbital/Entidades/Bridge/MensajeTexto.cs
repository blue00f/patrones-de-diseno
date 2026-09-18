namespace EstacionOrbital.Entidades.Bridge
{
    public class MensajeTexto : Mensaje
    {
        public MensajeTexto(ICifrado cifrado, string contenido) : base(cifrado, contenido) { }
        protected override string Tipo => "MENSAJE DE TEXTO";
        protected override string Prioridad => "baja";
    }
}
