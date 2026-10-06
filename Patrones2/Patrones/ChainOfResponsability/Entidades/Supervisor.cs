namespace ChainOfResponsability.Entidades
{
    public class Supervisor : ManejadorAprobacion
    {
        private const decimal LimiteAprobacion = 50000m;
        public override void Manejar(string solicitante, decimal monto, string concepto)
        {
            if (monto <= LimiteAprobacion)
            {
                Console.WriteLine($"[Supervisor] Aprobada: ${monto:N2} para '{concepto}' (solicitado por {solicitante})");
            }
            else if (siguiente != null)
            {
                Console.WriteLine($"[Supervisor] Supera mi límite (${LimiteAprobacion:N2}) -> derivo a Gerente");
                siguiente.Manejar(solicitante, monto, concepto);
            }
            else
            {
                Console.WriteLine($"[Supervisor] No puedo aprobar y no hay siguiente en la cadena.");
            }
        }
    }
}
