using State2.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Reproductor reproductor = new Reproductor();
        Console.WriteLine("=== Reproductor de audio ===");
        Console.WriteLine($"Estado inicial: {reproductor.NombreEstado} | Canción: {reproductor.CancionActual}\n");

        Console.WriteLine("1) Siguiente (en Listo):");
        reproductor.ClickSiguiente();

        Console.WriteLine("\n2) Play:");
        reproductor.ClickPlay();

        Console.WriteLine("\n3) Siguiente con un click (en Reproduciendo):");
        reproductor.ClickSiguiente();

        Console.WriteLine("\n4) Anterior con un click (en Reproduciendo):");
        reproductor.ClickAnterior();

        Console.WriteLine("\n5) Siguiente con doble click (en Reproduciendo):");
        reproductor.ClickSiguiente(true);

        Console.WriteLine("\n6) Bloquear mientras suena música:");
        reproductor.ClickBloquear();

        Console.WriteLine("\n7) Play estando bloqueado:");
        reproductor.ClickPlay();

        Console.WriteLine("\n8) Desbloquear (la música seguía sonando):");
        reproductor.ClickBloquear();

        Console.WriteLine("\n9) Play (detiene la reproducción):");
        reproductor.ClickPlay();

        Console.WriteLine("\n10) Bloquear (sin música):");
        reproductor.ClickBloquear();

        Console.WriteLine("\n11) Siguiente estando bloqueado:");
        reproductor.ClickSiguiente();

        Console.WriteLine("\n12) Desbloquear (sin música):");
        reproductor.ClickBloquear();

        Console.WriteLine($"\nEstado final: {reproductor.NombreEstado}");

        Console.ReadKey();
    }
}