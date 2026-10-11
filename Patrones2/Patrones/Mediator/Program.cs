using Mediator.Entidades;

class Program
{
    static void Main(string[] args)
    {

        CentralGuardia central = new CentralGuardia();
        central.Medico = new Medico(central);
        central.Laboratorio = new Laboratorio(central);
        central.Farmacia = new Farmacia(central);
        central.Enfermeria = new Enfermeria(central);

        Console.WriteLine("=== Pedido de estudio ===");
        central.Medico.SolicitarEstudio("Paul McCartney");

        Console.WriteLine("\n=== Resultado listo ===");
        central.Laboratorio.EntregarResultado("John Lennon");

        Console.WriteLine("\n=== Indicación de medicación ===");
        central.Medico.IndicarMedicacion("Ringo Starr");

        Console.ReadKey();
    }
}