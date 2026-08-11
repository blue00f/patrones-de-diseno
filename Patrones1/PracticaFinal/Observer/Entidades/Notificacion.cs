namespace Observer.Entidades
{
    public class Notificacion : IObservador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public void Actualizar(Pedido pedido)
        {
            Console.WriteLine($"[Notificaciones - {Nombre}] Tu pedido #{pedido.Id} cambió a: {pedido.Estado}");
        }
        public Notificacion(int id, string nombre) { Id = id; Nombre = nombre; }
        public override string ToString()
        {
            return $"ID: {this.Id} - Nombre: {this.Nombre}";
        }
    }
}
