namespace Observer.Entidades
{
    public class Auditoria : IObservador
    {
        public int Id { get; set; }
        public void Actualizar(Pedido pedido)
        {
            Console.WriteLine($"[Auditoría - {Id}] Pedido #{pedido.Id} | Estado: {pedido.Estado} | Total: ${pedido.Total:N2}");
        }
        public Auditoria(int id) { Id = id; }
        public override string ToString()
        {
            return $"ID: {this.Id}";
        }
    }
}
