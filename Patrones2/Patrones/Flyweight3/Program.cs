using Flyweight3.Entidades;

class Program
{
    static void Main(string[] args)
    {
        FabricaEspecies fabrica = new FabricaEspecies();
        List<Tripulante> tripulantes = new List<Tripulante>();

        Console.WriteLine("=== Creando 10.000 tripulantes de 5 especies conocidas (vía Fábrica) ===\n");
        string[] nombresEspecies = { "Humano", "Andoriano", "Vulcaniano", "Klingon", "Ferengi" };
        Random ran = new Random();
        for (int i = 0; i < 10000; i++)
        {
            string especieElegida = nombresEspecies[i % 5];
            IEspecie especie = fabrica.ObtenerEspecie(especieElegida, "Variable", "Planeta", "Dieta estándar");
            tripulantes.Add(new Tripulante($"Tripulante{i}", i, "Oficial", especie));

        }
        Console.WriteLine("\n=== Apareció un tripulante con una especie híbrida ÚNICA ===");
        IEspecie especieHibrida = new EspecieUnica("Humano-Vulcaniano", "Verdosa pálida", "Desconocido (nacido en tránsito)", "Mixta", "Caso médico registrado, requiere seguimiento especial");
        Tripulante tripulanteEspecial = new Tripulante("Spock Jr.", 9999, "Científico Jefe", especieHibrida);
        tripulantes.Add(tripulanteEspecial);

        Console.WriteLine("\n=== Mostrando una muestra de tripulantes ===");
        tripulantes[0].MostrarInfo();
        tripulantes[5000].MostrarInfo();
        tripulanteEspecial.MostrarInfo();

        Console.WriteLine($"\nTotal de tripulantes: {tripulantes.Count}");
        Console.WriteLine($"Especies COMPARTIDAS realmente en memoria (vía fábrica): {fabrica.CantidadEspeciesEnMemoria()}");
        Console.WriteLine($"Especies NO compartidas creadas aparte: 1 (la híbrida)");

        Console.ReadKey();
    }
}