namespace Decorator2.Entidades
{
    public abstract class BebidaDecorator : Bebida
    {
        protected Bebida bebida;
        public BebidaDecorator(Bebida bebida)
        {
            this.bebida = bebida;
        }
    }
}
