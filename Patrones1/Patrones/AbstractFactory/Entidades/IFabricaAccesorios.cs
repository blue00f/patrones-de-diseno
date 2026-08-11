namespace AbstractFactory.Entidades
{
    public interface IFabricaAccesorios
    {
        IMouse CrearMouse();
        ITeclado CrearTeclado();
    }
}
