using Decorator2.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Bebida pedido1 = new CafeBase();
        MostrarPedido(pedido1);

        Bebida pedido2 = new Leche(new CafeBase());
        MostrarPedido(pedido2);

        Bebida pedido3 = new ExtraShot(new Canela(new CafeBase()));
        MostrarPedido(pedido3);

        Console.ReadKey();
    }
    static void MostrarPedido(Bebida bebida)
    {
        Console.WriteLine($"Pedido: {bebida.Descripcion}");
        Console.WriteLine($"Total: {bebida.Costo():N2}\n");
    }
}