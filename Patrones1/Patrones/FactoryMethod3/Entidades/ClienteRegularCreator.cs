namespace FactoryMethod3.Entidades
{
    public class ClienteRegularCreator : ClienteCreator
    {
        public override CalculadoraDescuento CrearCalculadora() => new DescuentoClienteRegular();
    }
}
