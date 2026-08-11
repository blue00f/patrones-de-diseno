using Memento.Entidades;

class Program
{
    static void Main(string[] args)
    {
        ConfiguracionPerfil config = new ConfiguracionPerfil("bluegamer777", "Claro", 11);
        Historial historial = new Historial();

        Console.WriteLine("--- Estado inicial ---");
        Console.WriteLine(config);
        Console.WriteLine();

        historial.Guardar(config.Crear());
        config.TemaVisual = "Oscuro";
        Console.WriteLine("--- Cambio 1 ---");
        Console.WriteLine(config);
        Console.WriteLine();

        historial.Guardar(config.Crear());
        config.TamanioFuente = 16;
        Console.WriteLine("--- Cambio 2 ---");
        Console.WriteLine(config);
        Console.WriteLine();

        historial.Guardar(config.Crear());
        config.NombreUsuario = "blusito123";
        Console.WriteLine("--- Cambio 3 ---");
        Console.WriteLine(config);
        Console.WriteLine();

        Console.WriteLine("--- Deshacer 1 ---");
        config.Restaurar(historial.Deshacer());
        Console.WriteLine(config);
        Console.WriteLine();

        Console.WriteLine("--- Deshacer 2 ---");
        config.Restaurar(historial.Deshacer());
        Console.WriteLine(config);
        Console.WriteLine();

        Console.WriteLine("--- Deshacer 3 ---");
        config.Restaurar(historial.Deshacer());
        Console.WriteLine(config);
        Console.WriteLine();

        Console.ReadKey();
    }
}