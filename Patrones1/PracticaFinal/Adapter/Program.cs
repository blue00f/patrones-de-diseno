using Adapter.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Emisión de facturas ---");
        FacturacionLegado facturacionLegado = new FacturacionLegado();
        IFacturador facturador = new FacturadorAdapter(facturacionLegado);

        facturador.EmitirFactura("Bruno", 125000m, "ARS");
        facturador.EmitirFactura("José", 300m, "PESOS COLOMBIANOS");

        Console.ReadKey();
    }
}