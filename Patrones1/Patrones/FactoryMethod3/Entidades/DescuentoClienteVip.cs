namespace FactoryMethod3.Entidades
{
    public class DescuentoClienteVip : CalculadoraDescuento
    {
        public override decimal ObtenerPorcentaje() => 15m;
    }
}
