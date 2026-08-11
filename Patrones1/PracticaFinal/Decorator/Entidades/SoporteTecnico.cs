namespace Decorator.Entidades
{
    public class SoporteTecnico : ServicioAdicionalDecorator
    {
        public SoporteTecnico(PlanInternet plan) : base(plan) { }
        public override string Descripcion => $"{plan.Descripcion} + Soporte Técnico";
        public override decimal CalcularCosto() => plan.CalcularCosto() + 900m;
    }
}
