namespace Decorator.Entidades
{
    public class Telefonia : ServicioAdicionalDecorator
    {
        public Telefonia(PlanInternet plan) : base(plan) { }
        public override string Descripcion => $"{plan.Descripcion} + Telefonía";
        public override decimal CalcularCosto() => plan.CalcularCosto() + 2500m;
    }
}
