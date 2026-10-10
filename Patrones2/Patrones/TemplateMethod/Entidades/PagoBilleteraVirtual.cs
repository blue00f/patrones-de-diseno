namespace TemplateMethod.Entidades
{
    public class PagoBilleteraVirtual : ProcesadorPago
    {
        protected override bool EjecutarPago(decimal total)
        {
            Console.WriteLine($"Autorizando pago con billetera virtual por ${total}...");
            return true;
        }
        protected override decimal CalcularComision(decimal importe)
        {
            return importe * 0.02m;
        }
    }
}
