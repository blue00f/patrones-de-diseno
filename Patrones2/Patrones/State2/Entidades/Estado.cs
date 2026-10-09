namespace State2.Entidades
{
    public abstract class Estado
    {
        protected Reproductor reproductor;
        protected Estado(Reproductor reproductor)
        {
            this.reproductor = reproductor;
        }
        public abstract string Nombre { get; }
        public abstract void ClickBloquear();
        public abstract void ClickPlay();
        public abstract void ClickSiguiente(bool dobleClick);
        public abstract void ClickAnterior(bool dobleClick);
    }
}
