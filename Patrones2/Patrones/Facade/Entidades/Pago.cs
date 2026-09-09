namespace Facade.Entidades
{
    public class Pago
    {
        public bool ProcesarPago(string metodoPago, decimal monto)
        {
            Console.WriteLine($"\t[Pago] Procesando pago de ${monto:N2} con {metodoPago}...");
            return true; // siempre se acepta el pago, está hecho así a fines prácticos
        }
    }
}
