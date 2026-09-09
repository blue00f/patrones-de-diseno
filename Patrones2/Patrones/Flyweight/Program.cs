using Flyweight.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Bosque bosque = new Bosque();
        Random ran = new Random();

        Console.WriteLine("===== Plantando 10.000 árboles (solo 3 tipos distintos) =====\n");
        for (int i=0; i<10000; i++)
        {
            int x = ran.Next(0, 1000);
            int y = ran.Next(0, 1000);
            int variante = i % 3;
            if (variante == 0) bosque.PlantarArbol(x, y, "Pino", "Verde oscuro", "textura_pino.png");
            else if (variante == 1) bosque.PlantarArbol(x, y, "Roble", "Verde claro", "textura_roble.png");
            else bosque.PlantarArbol(x, y, "Sauce", "Verde amarillento", "textura_sauce.png");
        }
        Console.WriteLine("\n=== Dibujando una muestra de 5 árboles (de los 10.000 plantados) ===");
        bosque.DibujarMuestra(5);
        bosque.MostrarEstadisticas();
        Console.ReadKey();
    }
}