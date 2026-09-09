namespace Builder.Entidades
{
    public class ComputadoraBuilderOficina : IComputadoraBuilder
    {
        Computadora computadora;
        public ComputadoraBuilderOficina()
        {
            Reset();
        }
        public void Reset()
        {
            computadora = new Computadora();
        }
        public void PonerProcesador() => computadora.Procesador = "Intel Core i3 12100";
        public void PonerMemoriaRam() => computadora.MemoriaRam = "8 GB DDR4";
        public void PonerAlmacenamiento() => computadora.Almacenamiento = "480 GB SSD";
        public void PonerPlacaDeVideo() { }
        public void PonerRefrigeracion() { }
        public Computadora ObtenerComputadora()
        {
            Computadora res = computadora;
            Reset();
            return res;
        }
    }
}
