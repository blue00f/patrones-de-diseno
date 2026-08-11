using Composite;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Producto p1 = new Producto("Teclado", 4000);
        Producto p2 = new Producto("Mouse", 2000);
        Producto p3 = new Producto("Monitor", 9000);
        Producto p4 = new Producto("Microfono", 1000);

        Combo c1 = new Combo("C1");
        Combo c2 = new Combo("C2");

        c1.Agregar(p1);
        c1.Agregar(p2);
        c2.Agregar(p3);
        c2.Agregar(p4);
        c1.Agregar(c2);

        c1.Mostrar();
        Console.WriteLine($"\nTotal: {c1.CalcularTotal()}");
    }
}