namespace Visitor.Entidades
{
    public class Consulta : IItemFactura
    {
        public string Especialidad { get; set; }
        public decimal Honorarios { get; set; }
        public Consulta(string especialidad, decimal honorarios)
        {
            Especialidad = especialidad;
            Honorarios = honorarios;
        }
        public void Aceptar(IVisitante visitante) => visitante.Visitar(this);
    }
}
