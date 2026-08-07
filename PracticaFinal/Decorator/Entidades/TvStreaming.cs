namespace Decorator.Entidades
{
    public class TvStreaming : ServicioAdicionalDecorator
    {
        public TvStreaming(PlanInternet plan) : base(plan) { }
        public override string Descripcion => $"{plan.Descripcion} + TV Streaming";
        public override decimal CalcularCosto() => plan.CalcularCosto() + 900m;
    }
}
