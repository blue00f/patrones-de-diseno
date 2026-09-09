namespace Prototype.Entidades
{
    public class Contrato : IPrototypeContrato
    {
        List<Clausula> clausulas;
        public string TipoPlan { get; set; }
        public decimal MontoMensual { get; set; }
        public Contrato(string tipoPlan, decimal montoMensual, List<Clausula> clausulas)
        {
            TipoPlan = tipoPlan;
            MontoMensual = montoMensual;
            this.clausulas = clausulas;
        }
        public Contrato(Contrato prototipo)
        {
            TipoPlan = prototipo.TipoPlan;
            MontoMensual = prototipo.MontoMensual;
            this.clausulas = new List<Clausula>();
            foreach (var c in prototipo.clausulas)
            {
                this.clausulas.Add(new Clausula(c.Texto));
            }
        }
        public virtual IPrototypeContrato Clonar()
        {
            return new Contrato(this);
        }
        public void AgregarClausula(string texto) => this.clausulas.Add(new Clausula(texto));
        public override string ToString()
        {
            string clausulasTexto = string.Join(" / ", this.clausulas.ConvertAll(c => c.Texto));
            return $"Plan: {TipoPlan} | Mensual: ${MontoMensual:N2} | Cláusulas: {clausulasTexto}";
        }
    }
}
