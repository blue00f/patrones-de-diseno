namespace Observer.Entidades
{
    public class Logistica : IObservador
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public void Actualizar(Pedido pedido)
        {
            if(pedido.Estado == "Confirmado") Console.WriteLine($"[Logística - {Direccion}] Preparando envío del pedido #{pedido.Id}");
        }
        public Logistica(int id, string direccion) { Id = id; Direccion = direccion; }
        public override string ToString()
        {
            return $"ID: {this.Id} - Dirección: {this.Direccion}";
        }
    }
}
