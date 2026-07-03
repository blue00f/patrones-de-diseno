using Iterator;

class Program
{
    static void Main(string[] args)
    {
        CatalogoCelulares catalogo = new CatalogoCelulares();
        catalogo.Agregar(new Celular("Samsung", "Galaxy S25", 1200000));
        catalogo.Agregar(new Celular("Apple", "iPhone 17", 1900000));
        catalogo.Agregar(new Celular("Motorola", "Edge 60", 850000));
        catalogo.Agregar(new Celular("Xiaomi", "Redmi Note 15", 620000));

        IIterador iterador = catalogo.CrearIterador();
        Console.WriteLine("CATALOGO DE CELULARES");

        iterador.Primero();
        while (iterador.HaySiguiente())
        {
            Celular c = iterador.Actual();
            Console.WriteLine(c.ToString());
            iterador.Siguiente();
        }
        Console.ReadKey();
    }
}