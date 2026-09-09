using Facade.Entidades;

class Program
{
    static void Main(string[] args)
    {
        TiendaFacade tienda = new TiendaFacade();
        bool rdo = tienda.ComprarProducto("Lionel Messi", "Teclado Mecánico", 1, 60000m, "Tarjeta de crédito", "Av. Siempre Viva 742");

        if (!rdo)
        {
            Console.WriteLine("Compra realizada con éxito!");
        }
        else
        {
            Console.WriteLine("Error en la compra!");
        }
        Console.ReadKey();
    }
}