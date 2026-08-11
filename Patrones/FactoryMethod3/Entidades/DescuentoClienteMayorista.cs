namespace FactoryMethod3.Entidades
{
    public class DescuentoClienteMayorista : CalculadoraDescuento
    {
        public override decimal ObtenerPorcentaje() => 25m;
    }
}
