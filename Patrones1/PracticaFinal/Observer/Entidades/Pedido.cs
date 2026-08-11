namespace Observer.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string Estado { get; set; }
        public decimal Total { get; set; }
        public Pedido(int numero, string nombreCliente, string estado, decimal total)
        {
            Id = numero;
            NombreCliente = nombreCliente;
            Estado = estado;
            Total = total;
        }
        public override string ToString()
        {
            return $"ID: {this.Id} - Cliente: {this.NombreCliente} - Estado: {this.Estado} - Total: ${this.Total:N2}";
        }
    }
}
