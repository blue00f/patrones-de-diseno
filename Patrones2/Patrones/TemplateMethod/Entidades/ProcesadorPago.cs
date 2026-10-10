namespace TemplateMethod.Entidades
{
    public abstract class ProcesadorPago
    {
        public bool ProcesarPago(decimal importe)
        {
            bool rdo = false;
            if (importe <= 0)
            {
                Console.WriteLine("El importe debe ser mayor a cero.");
            }
            else
            {
                decimal comision = CalcularComision(importe);
                decimal total = importe + comision;

                Console.WriteLine($"Importe: ${importe}");
                Console.WriteLine($"Comisión: ${comision}");
                Console.WriteLine($"Total a pagar: ${total}");

                bool exitoso = EjecutarPago(total);

                if (!exitoso)
                {
                    Console.WriteLine("El pago fue rechazado.");
                }
                else
                {
                    RegistrarPago(total);
                    if (DebeNotificar())
                    {
                        NotificarPago(total);
                    }
                    Console.WriteLine("Pago procesado correctamente.");
                    rdo = true;
                }
            }
            return rdo;
        }
        private void RegistrarPago(decimal total) => Console.WriteLine($"Registrando pago de ${total:N2}...");
        protected abstract bool EjecutarPago(decimal total);
        protected virtual decimal CalcularComision(decimal importe) => 0;
        protected virtual bool DebeNotificar() => true;
        protected virtual void NotificarPago(decimal total) => Console.WriteLine($"Notificación enviada por ${total:N2}.");
    }
}
