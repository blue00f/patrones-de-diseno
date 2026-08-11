namespace Decorator2.Entidades
{
    public class CafeBase : Bebida
    {
        public override string Descripcion => "Café";
        public override decimal Costo() => 800m;
    }
}
