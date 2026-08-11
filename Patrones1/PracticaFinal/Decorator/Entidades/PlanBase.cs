namespace Decorator.Entidades
{
    public class PlanBase : PlanInternet
    {
        public override string Descripcion => "Plan Base";
        public override decimal CalcularCosto() => 8000m;
    }
}
