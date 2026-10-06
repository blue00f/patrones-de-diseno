using ChainOfResponsability.Entidades;

class Program
{
    static void Main(string[] args)
    {
        ManejadorAprobacion supervisor = new Supervisor();
        ManejadorAprobacion gerente = new Gerente();
        ManejadorAprobacion director = new Director();

        supervisor.EstablecerSiguiente(gerente);
        gerente.EstablecerSiguiente(director);

        Console.WriteLine("=== Solicitud 1: Insumos de bajo costo ===");
        supervisor.Manejar("Lionel Messi", 35000m, "Reposición de guantes y barbijos");

        Console.WriteLine("\n=== Solicitud 2: equipamiento de nivel medio ===");
        supervisor.Manejar("Ana Torres", 120000m, "Monitor de signos vitales");

        Console.WriteLine("\n=== Solicitud 3: equipamiento de alto costo ===");
        supervisor.Manejar("Juan Pérez", 450000m, "Ecógrafo portátil");

        Console.ReadKey();
    }
}