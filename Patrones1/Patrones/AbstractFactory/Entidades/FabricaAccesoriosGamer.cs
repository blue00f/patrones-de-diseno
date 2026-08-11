using System.Reflection.Metadata.Ecma335;

namespace AbstractFactory.Entidades
{
    public class FabricaAccesoriosGamer : IFabricaAccesorios
    {
        public IMouse CrearMouse() => new MouseGamer();
        public ITeclado CrearTeclado() => new TecladoGamer();
    }
}
