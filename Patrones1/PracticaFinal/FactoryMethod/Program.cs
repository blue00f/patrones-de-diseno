using FactoryMethod.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Emisión de comprobantes ===\n");

        // Factura A
        ComprobanteCreator creatorA = new FacturaACreator();
        Comprobante facturaA = creatorA.CrearComprobante();
        facturaA.Numero = "0001-00001234";
        ((FacturaA)facturaA).MontoNeto = 1000m;
        ((FacturaA)facturaA).PorcentajeIva = 0.21m;
        facturaA.Monto = ((FacturaA)facturaA).MontoNeto + ((FacturaA)facturaA).MontoIva;
        facturaA.Emitir();
        Console.WriteLine();

        // Factura B
        ComprobanteCreator creatorB = new FacturaBCreator();
        Comprobante facturaB = creatorB.CrearComprobante();
        facturaB.Numero = "0002-00005678";
        facturaB.Monto = 1210m;
        ((FacturaB)facturaB).Dni = "11223344";
        facturaB.Emitir();
        Console.WriteLine();

        // Nota de crédito
        ComprobanteCreator creatorNC = new NotaCreditoCreator();
        Comprobante notaCredito = creatorNC.CrearComprobante();
        notaCredito.Numero = "0003-00000045";
        notaCredito.Monto = 500m;
        ((NotaCredito)notaCredito).NumeroComprobanteAsociado = "0002-00005678";
        ((NotaCredito)notaCredito).Motivo = "Devolución de mercadería";
        notaCredito.Emitir();

        Console.ReadKey();
    }
}