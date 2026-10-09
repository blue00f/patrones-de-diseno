namespace Visitor.Entidades
{
    public class CalculadorTotal : IVisitante
    {
        private const decimal recargoInsumosEstudio = 0.10m;
        public decimal Total { get; set; }
        public void Visitar(Consulta consulta)
        {
            Total += consulta.Honorarios;
        }

        public void Visitar(Estudio estudio)
        {
            Total += estudio.Precio + (estudio.Precio * recargoInsumosEstudio);
        }

        public void Visitar(Medicamento medicamento)
        {
            Total += medicamento.PrecioUnitario * medicamento.Cantidad;
        }
    }
}
