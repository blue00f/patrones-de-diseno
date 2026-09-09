using Prototype.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ConcretePrototype: Contrato Básico ===");
        Contrato plantillaBasica = new Contrato("Básico", 5000m, new List<Clausula> { new Clausula("Soporte por email") });
        Console.WriteLine(plantillaBasica);

        Contrato copiaBasica = (Contrato)plantillaBasica.Clonar();
        copiaBasica.AgregarClausula("Cliente: Paul McCartney");

        Console.WriteLine("\n=== Clon de Contrato Básico, personalizado ===");
        Console.WriteLine(copiaBasica);
        Console.WriteLine("\n=== Plantilla básica original, intacta ===");
        Console.WriteLine(plantillaBasica);

        Console.WriteLine("\n\n=== SubclassPrototype: Contrato Premium ===");
        ContratoPremium plantillaPremium = new ContratoPremium("Premium", 12000m, new List<Clausula> { new Clausula("Renovación automática") }, "Sin asignar");
        Console.WriteLine(plantillaPremium);

        ContratoPremium copiaPremium = (ContratoPremium)plantillaPremium.Clonar();
        copiaPremium.AsesorAsignado = "Mon Laferte";
        copiaPremium.AgregarClausula("Cliente: María López");
        Console.WriteLine("\n=== Clon de Contrato Premium, personalizado ===");
        Console.WriteLine(copiaPremium);
        Console.WriteLine("\n=== Plantilla premium original, intacta ===");
        Console.WriteLine(plantillaPremium);

        Console.ReadKey();
    }
}