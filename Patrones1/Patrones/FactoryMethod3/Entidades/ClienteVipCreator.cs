namespace FactoryMethod3.Entidades
{
    public class ClienteVipCreator : ClienteCreator
    {
        public override CalculadoraDescuento CrearCalculadora() => new DescuentoClienteVip();
    }
}
