namespace Builder.Entidades
{
    public class ComputadoraBuilderGamer : IComputadoraBuilder
    {
        Computadora computadora;
        public ComputadoraBuilderGamer()
        {
            Reset();
        }
        public void Reset()
        {
            computadora = new Computadora();
        }
        public void PonerProcesador() => computadora.Procesador = "Intel Core i7 13700K";
        public void PonerMemoriaRam() => computadora.MemoriaRam = "32 GB DDR5";
        public void PonerAlmacenamiento() => computadora.Almacenamiento = "1 TB SSD NVMe";
        public void PonerPlacaDeVideo() => computadora.PlacaDeVideo = "NVIDIA RTX 4070";
        public void PonerRefrigeracion() => computadora.RefrigeracionLiquida = true;
        public Computadora ObtenerComputadora()
        {
            Computadora res = computadora;
            Reset();
            return res;
        }
    }
}
