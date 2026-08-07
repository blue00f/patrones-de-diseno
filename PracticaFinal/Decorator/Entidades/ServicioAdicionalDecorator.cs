namespace Decorator.Entidades
{
    public abstract class ServicioAdicionalDecorator : PlanBase
    {
        protected PlanInternet plan;
        public ServicioAdicionalDecorator(PlanInternet plan)
        {
            this.plan = plan;
        }
    }
}
