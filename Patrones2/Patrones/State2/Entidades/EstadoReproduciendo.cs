namespace State2.Entidades
{
    public class EstadoReproduciendo : Estado
    {
        public override string Nombre => "Reproduciendo";
        public EstadoReproduciendo(Reproductor reproductor) : base(reproductor) { }
        public override void ClickBloquear() => reproductor.CambiarEstado(new EstadoBloqueado(reproductor));

        public override void ClickPlay()
        {
            reproductor.DetenerReproduccion();
            reproductor.CambiarEstado(new EstadoListo(reproductor));
        }
        public override void ClickSiguiente(bool dobleClick)
        {
            if (dobleClick) reproductor.SiguienteCancion();
            else reproductor.AvanzarRapido(5);
        }
        public override void ClickAnterior(bool dobleClick)
        {
            if (dobleClick) reproductor.CancionAnterior();
            else reproductor.Retroceder(5);
        }
    }
}
