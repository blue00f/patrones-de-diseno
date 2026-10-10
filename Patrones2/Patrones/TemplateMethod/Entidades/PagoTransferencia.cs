namespace TemplateMethod.Entidades
{
    public class PagoTransferencia : ProcesadorPago
    {
        protected override bool EjecutarPago(decimal total)
        {
            Console.WriteLine($"Verificando transferencia bancaria por ${total}...");
            return true;
        }
        protected override bool DebeNotificar()
        {
            return false;
        }
    }
}
