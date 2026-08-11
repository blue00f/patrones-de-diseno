using AbstractFactory.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Combo Gamer ---");
        IFabricaAccesorios fabrica = new FabricaAccesoriosGamer();
        IMouse mouse = fabrica.CrearMouse();
        ITeclado teclado = fabrica.CrearTeclado();
        mouse.MostrarInfo();
        teclado.MostrarInfo();

        Console.WriteLine("--- Combo Oficina ---");
        fabrica = new FabricaAccesoriosOficina();
        mouse = fabrica.CrearMouse();
        teclado = fabrica.CrearTeclado();
        mouse.MostrarInfo();
        teclado.MostrarInfo();

        Console.ReadKey();
    }
}