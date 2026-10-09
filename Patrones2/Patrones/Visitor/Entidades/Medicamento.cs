namespace Visitor.Entidades
{
    public class Medicamento : IItemFactura
    {
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public Medicamento(string nombre, decimal precioUnitario, int cantidad)
        {
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
        }
        public void Aceptar(IVisitante visitante) => visitante.Visitar(this);
    }
}
