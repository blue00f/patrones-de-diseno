using State.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Conexión TCP ===");

        ConexionTcp conexion = new ConexionTcp();
        Console.WriteLine($"Estado inicial: {conexion.EstadoActual}\n");

        Console.WriteLine("1) Intento enviar con la conexión cerrada");
        conexion.Enviar();

        Console.WriteLine("2) Apertura activa");
        conexion.AperturaActiva();

        Console.WriteLine("\n3) Transmito datos");
        conexion.Transmitir("11100011");

        Console.WriteLine("\n4) Intento otra apertura activa estando ya establecida");
        conexion.AperturaActiva();

        Console.WriteLine("\n5) Cierro la conexión");
        conexion.Cerrar();

        Console.WriteLine("\n6) Intento transmitir sin conexión establecida");
        conexion.Transmitir("11110000");

        Console.WriteLine($"\n7) Envío (donde escucha, se vuelve a establecer)");
        conexion.Enviar();

        Console.WriteLine($"\nEstado final: {conexion.EstadoActual}");
        Console.ReadKey();
    }
}