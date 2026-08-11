namespace FactoryMethod3.Entidades
{
    public class ClienteMayoristaCreator : ClienteCreator
    {
        public override CalculadoraDescuento CrearCalculadora() => new DescuentoClienteMayorista();
    }
}
