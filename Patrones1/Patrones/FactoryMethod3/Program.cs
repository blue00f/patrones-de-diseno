using FactoryMethod3.Entidades;

class Program
{
    static void Main(string[] args)
    {
        ClienteCreator creator;

        Console.WriteLine("--- Cliente Regular ---");
        creator = new ClienteRegularCreator();
        creator.ProcesarCompra(1000m);

        Console.WriteLine("--- Cliente VIP ---");
        creator = new ClienteVipCreator();
        creator.ProcesarCompra(1000m);

        Console.WriteLine("--- Cliente Mayorista ---");
        creator = new ClienteMayoristaCreator();
        creator.ProcesarCompra(1000m);

        Console.ReadLine();
    }
}