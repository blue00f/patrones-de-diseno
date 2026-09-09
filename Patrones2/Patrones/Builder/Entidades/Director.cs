namespace Builder.Entidades
{
    public class Director
    {
        IComputadoraBuilder builder;
        public Director(IComputadoraBuilder builder)
        {
            this.builder = builder;
        }
        public void CambiarBuilder(IComputadoraBuilder builder)
        {
            this.builder = builder;
        }
        public void ConstruirCompleta()
        {
            builder.Reset();
            builder.PonerProcesador();
            builder.PonerMemoriaRam();
            builder.PonerAlmacenamiento();
            builder.PonerPlacaDeVideo();
            builder.PonerRefrigeracion();
        }
        public void ConstruirBasica()
        {
            builder.Reset();
            builder.PonerProcesador();
            builder.PonerMemoriaRam();
            builder.PonerAlmacenamiento();
        }
    }
}
