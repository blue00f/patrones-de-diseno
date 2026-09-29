using Ej2;
using System.Diagnostics;

class Program
{

    static Random ran = new Random();
    static List<Participante> participantes = new List<Participante>();
    static void Main(string[] args)
    {
        CargarLista();
        List<Thread> hilos = new List<Thread>();

        foreach (Participante p in participantes)
        {
            Thread hilo = new Thread(() => Correr(p));
            hilo.Name = $"{p.Nombre} {p.Apellido}";
            hilos.Add(hilo);
            hilo.Start();
        }
        foreach (Thread hilo in hilos)
        {
            hilo.Join();
        }
        Console.WriteLine("\nTodos los participantes terminaron.");

        Console.WriteLine("--- ESTADÍSTICAS ---");
        MostrarTiempoTotalPorPais();
    }
    static void Correr(Participante participante)
    {
        Stopwatch cronometro = new Stopwatch();
        cronometro.Start();
        Thread.Sleep(ran.Next(1000, 5000));
        cronometro.Stop();
        participante.Tiempo = cronometro.Elapsed;
        Console.WriteLine($"{participante.Nombre} {participante.Apellido} ({participante.Pais}) tardó {participante.Tiempo.TotalSeconds:F3} segundos.");
    }
    private static void MostrarTiempoTotalPorPais()
    {
        var consulta = from p in participantes
                       group p by p.Pais into grupoPais
                       orderby participantes descending
                       select new
                       {
                           Pais = grupoPais.Key,
                           TiempoTotal = new TimeSpan(grupoPais.Sum(p => p.Tiempo.Ticks))
                       } into resultado
                       orderby resultado.TiempoTotal
                       select resultado;
        foreach (var t in consulta)
        {
            Console.WriteLine($"País: {t.Pais} - Tiempo total: {t.TiempoTotal.TotalSeconds:F3}");
        }
    }
    private static void MostrarMejoresDiez()
    {
        var consulta = (from p in participantes orderby p.Tiempo select p).Take(10);
        return consulta;
    }
    private static void CargarLista()
    {
        participantes.AddRange(new List<Participante>
        {
            new Participante("Lionel", "Messi", "Argentina"),
            new Participante("Ángel", "Di María", "Argentina"),
            new Participante("Emiliano", "Martínez", "Argentina"),
            new Participante("Julián", "Álvarez", "Argentina"),
            new Participante("Luis", "Suárez", "Uruguay"),
            new Participante("Edinson", "Cavani", "Uruguay"),
            new Participante("Federico", "Valverde", "Uruguay"),
            new Participante("Darwin", "Núñez", "Uruguay"),
            new Participante("Alexis", "Sánchez", "Chile"),
            new Participante("Arturo", "Vidal", "Chile"),
            new Participante("Claudio", "Bravo", "Chile"),
            new Participante("Gary", "Medel", "Chile"),
            new Participante("Neymar", "Júnior", "Brasil"),
            new Participante("Vinícius", "Júnior", "Brasil"),
            new Participante("Rodrygo", "Goes", "Brasil"),
            new Participante("Casemiro", "Silva", "Brasil")
        });
    }
}