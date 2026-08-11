namespace Decorator2.Entidades
{
    public class ExtraShot : BebidaDecorator
    {
        public ExtraShot(Bebida bebida) : base(bebida) { }
        public override string Descripcion => $"{bebida.Descripcion} + Shot extra";
        public override decimal Costo() => bebida.Costo() + 300m;
    }
}
