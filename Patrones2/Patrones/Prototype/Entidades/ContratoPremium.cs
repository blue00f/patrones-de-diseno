namespace Prototype.Entidades
{
    public class ContratoPremium : Contrato
    {
        public string AsesorAsignado { get; set; }
        public ContratoPremium(string tipoPlan, decimal montoMensual, List<Clausula> clausulas, string asesorAsignado) : base(tipoPlan, montoMensual, clausulas)
        {
            AsesorAsignado = asesorAsignado;
        }
        public ContratoPremium(ContratoPremium prototipo) : base(prototipo)
        {
            AsesorAsignado = prototipo.AsesorAsignado;
        }
        public override IPrototypeContrato Clonar()
        {
            return new ContratoPremium(this);
        }
        public override string ToString()
        {
            return base.ToString() + $" | Asesor asignado: {AsesorAsignado}";
        }
    }
}
