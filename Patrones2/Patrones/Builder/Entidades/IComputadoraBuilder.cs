namespace Builder.Entidades
{
    public interface IComputadoraBuilder
    {
        void Reset();
        void PonerProcesador();
        void PonerMemoriaRam();
        void PonerAlmacenamiento();
        void PonerPlacaDeVideo();
        void PonerRefrigeracion();
        Computadora ObtenerComputadora();
    }
}
