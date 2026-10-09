using Visitor.Entidades;

class Program
{
    static void Main(string[] args)
    {
        List<IItemFactura> items = new List<IItemFactura>
        {
            new Consulta("Cardiología", 25000m),
            new Estudio("Análisis de sangre", 12000m, true),
            new Medicamento("Ibuprofeno", 1500m, 2),
            new Estudio("Ecografía", 18000m, false)
        };

        Console.WriteLine("=== Detalle de la factura ===");
        ImpresorDetalle impresor = new ImpresorDetalle();
        foreach (var i in items)
        {
            i.Aceptar(impresor);
        }

        Console.WriteLine("\n=== Total de la factura ===");
        CalculadorTotal calculador = new CalculadorTotal();
        foreach (var i in items)
        {
            i.Aceptar(calculador);
        }
        Console.WriteLine($"Total a pagar: ${calculador.Total:N2}");

        Console.ReadKey();
    }
}