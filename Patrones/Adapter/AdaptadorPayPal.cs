namespace Adapter
{
    public class AdaptadorPayPal : IPasarelaPago
    {
        Paypal paypal;

        public AdaptadorPayPal(Paypal payPal)
        {
            this.paypal = payPal;
        }
        public void ProcesarPago(decimal monto)
        {
            paypal.RealizarPago((double)monto);
        }
    }
}
