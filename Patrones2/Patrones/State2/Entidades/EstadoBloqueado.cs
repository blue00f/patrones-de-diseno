namespace State2.Entidades
{
    public class EstadoBloqueado : Estado
    {
        public override string Nombre => "Bloqueado";
        public EstadoBloqueado(Reproductor reproductor) : base(reproductor) { }

        public override void ClickBloquear()
        {
            if (reproductor.Reproduciendo)
            {
                reproductor.CambiarEstado(new EstadoReproduciendo(reproductor));
            }
            else
            {
                reproductor.CambiarEstado(new EstadoListo(reproductor));
            }
        }
        public override void ClickPlay() => Ignorar();
        public override void ClickSiguiente(bool dobleClick) => Ignorar();
        public override void ClickAnterior(bool dobleClick) => Ignorar();
        private void Ignorar() => Console.WriteLine($"\t[{Nombre}] Botón ignorado.");
    }
}
