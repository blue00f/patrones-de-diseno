using Strategy.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Facturación de consulta ===");
        FacturaConsulta factura = new FacturaConsulta("Paul McCartney", "consulta clínica", 30000m, new SinCobertura());
        Console.WriteLine("1) Sin cobertura:");
        factura.Emitir();

        Console.WriteLine("\n2) Obra social básica (cubre 50%):");
        factura.CambiarEstrategia(new ObraSocialBasica());
        factura.Emitir();

        Console.WriteLine("\n3) Obra social plus (cubre 80% con tope de $20.000):");
        factura.CambiarEstrategia(new ObraSocialPlus());
        factura.Emitir();

        Console.WriteLine("\n4) Prepaga (copago fijo de $3.000):");
        factura.CambiarEstrategia(new Prepaga());
        factura.Emitir();

        Console.ReadKey();
    }
}