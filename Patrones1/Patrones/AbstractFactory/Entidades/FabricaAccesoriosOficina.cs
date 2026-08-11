namespace AbstractFactory.Entidades
{
    public class FabricaAccesoriosOficina : IFabricaAccesorios
    {
        public IMouse CrearMouse() => new MouseOficina();
        public ITeclado CrearTeclado() => new TecladoOficina();
    }
}
