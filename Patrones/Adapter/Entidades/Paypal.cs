namespace Adapter.Entidades
{
    public class Paypal
    {
        public void RealizarPago(double importe)
        {
            Console.WriteLine($"Pago realizado con PayPal por ${importe}");
        }
    }
}
