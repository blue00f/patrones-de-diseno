using Decorator.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Planes de Internet ---");
        PlanInternet plan1 = new PlanBase();
        Console.WriteLine($"Plan contratado: {plan1.Descripcion}\nCosto mensual: ${plan1.CalcularCosto():N2}\n");

        PlanInternet plan2 = new TvStreaming(new SoporteTecnico(new PlanBase()));
        Console.WriteLine($"Plan contratado: {plan2.Descripcion}\nCosto mensual: ${plan2.CalcularCosto():N2}\n");

        PlanInternet plan3 = new TvStreaming(new SoporteTecnico(new Telefonia(new IpFija(new PlanBase()))));
        Console.WriteLine($"Plan contratado: {plan3.Descripcion}\nCosto mensual: ${plan3.CalcularCosto():N2}\n");
    }
}