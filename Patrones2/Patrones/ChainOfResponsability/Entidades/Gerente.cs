namespace ChainOfResponsability.Entidades
{
    public class Gerente : ManejadorAprobacion
    {
        private const decimal LimiteAprobacion = 200000m;
        public override void Manejar(string solicitante, decimal monto, string concepto)
        {
            if (monto <= LimiteAprobacion)
            {
                Console.WriteLine($"[Gerente] Aprobada: ${monto:N2} para '{concepto}' (solicitado por {solicitante})");
            }
            else if (siguiente != null)
            {
                Console.WriteLine($"[Gerente] Supera mi límite (${LimiteAprobacion:N2}) -> derivo a Director");
                siguiente.Manejar(solicitante, monto, concepto);
            }
            else
            {
                Console.WriteLine($"[Gerente] No puedo aprobar y no hay siguiente en la cadena.");
            }
        }
    }
}
