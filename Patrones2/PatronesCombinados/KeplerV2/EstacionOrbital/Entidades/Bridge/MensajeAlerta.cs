namespace EstacionOrbital.Entidades.Bridge
{
    public class MensajeAlerta : Mensaje
    {
        public MensajeAlerta(ICifrado cifrado, string contenido) : base(cifrado, contenido) { }
        protected override string Tipo => "MENSAJE DE ALERTA";
        protected override string Prioridad => "media";
    }
}
