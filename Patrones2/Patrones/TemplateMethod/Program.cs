using TemplateMethod.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Pago realizado con tarjeta ===");
        ProcesadorPago pago1 = new PagoTarjeta();
        pago1.ProcesarPago(10000m);

        Console.WriteLine("\n=== Pago realizado con transferencia ===");
        ProcesadorPago pago2 = new PagoTransferencia();
        pago2.ProcesarPago(10000m);

        Console.WriteLine("\n=== Pago realizado con billetera virtual ===");
        ProcesadorPago pago3 = new PagoBilleteraVirtual();
        pago3.ProcesarPago(10000m);

        Console.ReadKey();
    }
}