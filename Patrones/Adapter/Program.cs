using Adapter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Mercado Pago ===");

        IPasarelaPago pago1 = new MercadoPago();
        pago1.ProcesarPago(25000);

        Console.WriteLine();

        Console.WriteLine("=== PayPal mediante Adapter ===");

        Paypal payPal = new Paypal();

        IPasarelaPago pago2 = new AdaptadorPayPal(payPal);
        pago2.ProcesarPago(42000);

        Console.ReadKey();
    }
}