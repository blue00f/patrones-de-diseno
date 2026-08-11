namespace Decorator.Entidades
{
    public class IpFija : ServicioAdicionalDecorator
    {
        public IpFija(PlanInternet plan) : base(plan) { }
        public override string Descripcion => $"{plan.Descripcion} + IP Fija";
        public override decimal CalcularCosto() => plan.CalcularCosto() + 600m;
    }
}
