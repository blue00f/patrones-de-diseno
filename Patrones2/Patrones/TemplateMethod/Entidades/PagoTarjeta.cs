namespace TemplateMethod.Entidades
{
    public class PagoTarjeta : ProcesadorPago
    {
        protected override bool EjecutarPago(decimal total)
        {
            Console.WriteLine($"Procesando pago con tarjeta por ${total}...");
            return true;
        }
        protected override decimal CalcularComision(decimal importe)
        {
            return importe * 0.05m;
        }
    }
}
