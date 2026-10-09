namespace Visitor.Entidades
{
    public class Estudio : IItemFactura
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public bool RequiereAyuno { get; set; }
        public Estudio(string nombre, decimal precio, bool requiereAyuno)
        {
            Nombre = nombre;
            Precio = precio;
            RequiereAyuno = requiereAyuno;
        }
        public void Aceptar(IVisitante visitante) => visitante.Visitar(this);
    }
}
