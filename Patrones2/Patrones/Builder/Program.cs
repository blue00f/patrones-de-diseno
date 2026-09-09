using Builder.Entidades;

class Program
{
    static void Main(string[] args)
    {
        ComputadoraBuilderGamer builderGamer = new ComputadoraBuilderGamer();
        ComputadoraBuilderOficina builderOficina = new ComputadoraBuilderOficina();

        Director director = new Director(builderGamer);
        Console.WriteLine("########## CON DIRECTOR ##########");
        Console.WriteLine("=== PC Gamer (Director + CambiarBuilder) ===");
        director.ConstruirCompleta();
        Console.WriteLine(builderGamer.ObtenerComputadora());

        Console.WriteLine("\n=== PC de Oficina (Director + CambiarBuilder) ===");
        director.CambiarBuilder(builderOficina);
        director.ConstruirBasica();
        Console.WriteLine(builderOficina.ObtenerComputadora());

        Console.WriteLine("########## SIN DIRECTOR (builder directo) ##########");
        Console.WriteLine("\n=== PC Gamer armada a mano ===");
        builderGamer.Reset();
        builderGamer.PonerProcesador();
        builderGamer.PonerMemoriaRam();
        builderGamer.PonerAlmacenamiento();
        builderGamer.PonerPlacaDeVideo();
        Console.WriteLine(builderGamer.ObtenerComputadora());

        Console.WriteLine("\n=== PC de Oficina armada a mano ===");
        builderOficina.Reset();
        builderOficina.PonerProcesador();
        builderOficina.PonerMemoriaRam();
        builderOficina.PonerAlmacenamiento();
        Console.WriteLine(builderOficina.ObtenerComputadora());

        Console.ReadKey();
    }
}