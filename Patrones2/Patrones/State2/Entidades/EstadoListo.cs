namespace State2.Entidades
{
    public class EstadoListo : Estado
    {
        public override string Nombre => "Listo";
        public EstadoListo(Reproductor reproductor) : base(reproductor) { }
        public override void ClickBloquear()
        {
            reproductor.CambiarEstado(new EstadoBloqueado(reproductor));
        }
        public override void ClickPlay()
        {
            reproductor.IniciarReproduccion();
            reproductor.CambiarEstado(new EstadoReproduciendo(reproductor));
        }
        public override void ClickSiguiente(bool dobleClick) => reproductor.SiguienteCancion();
        public override void ClickAnterior(bool dobleClick) => reproductor.CancionAnterior();
    }
}
