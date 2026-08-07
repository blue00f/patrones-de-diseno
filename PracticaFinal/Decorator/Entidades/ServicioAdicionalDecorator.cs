namespace Decorator.Entidades
{
    public abstract class ServicioAdicionalDecorator : PlanInternet
    {
        protected PlanInternet plan;
        public ServicioAdicionalDecorator(PlanInternet plan)
        {
            this.plan = plan;
        }
    }
}
