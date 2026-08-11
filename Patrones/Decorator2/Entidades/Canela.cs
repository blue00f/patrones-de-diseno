namespace Decorator2.Entidades
{
    public class Canela : BebidaDecorator
    {
        public Canela(Bebida bebida) : base(bebida) { }
        public override string Descripcion => $"{bebida.Descripcion} + Canela";
        public override decimal Costo() => bebida.Costo() + 80m;
    }
}
