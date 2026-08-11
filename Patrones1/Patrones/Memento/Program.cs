using Memento.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Celular c = new Celular("Samsung","Galaxy S25",1200000);
        Historial historial = new Historial();

        Console.WriteLine($"Estado inicial\n{c.ToString()}");
        historial.Guardar(c.CrearMemento());

        Console.WriteLine("Se modifica el precio...");
        c.Precio = 1350000;
        Console.WriteLine($"{c.ToString()}");

        historial.Guardar(c.CrearMemento());

        Console.WriteLine("Se modifica el modelo...");
        c.Modelo = "Galaxy S25 Ultra";
        Console.WriteLine($"{c.ToString()}");

        Console.WriteLine("Deshaciendo cambios...");
        c.Restaurar(historial.Deshacer());
        c.Restaurar(historial.Deshacer());

        Console.WriteLine($"{c.ToString()}");
        Console.ReadKey();
    }
}