namespace Adapter
{
    public class MercadoPago : IPasarelaPago
    {
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"Pago realizado con Mercado Pago por ${monto}");
        }
    }
}
