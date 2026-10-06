namespace ChainOfResponsability.Entidades
{
    public class Director : ManejadorAprobacion
    {
        public override void Manejar(string solicitante, decimal monto, string concepto)
        {
            Console.WriteLine($"[Director] Aprobada: ${monto:N2} para '{concepto}' (solicitado por {solicitante}) -- autorización máxima");
        }
    }
}
