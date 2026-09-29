
using Ej1;
using System.Diagnostics;

class Program
{
    static Random ran = new Random();
    static Stopwatch cronometro = new Stopwatch();
    static List<Participante> participantes = new List<Participante>();
    static void Main(string[] args)
    {
        CargarLista();

        Thread hiloArgentina = new Thread(() => GenerarParticipante("Argentina"));
        Thread hiloUruguay = new Thread(() => GenerarParticipante("Uruguay"));
        Thread hiloChile = new Thread(() => GenerarParticipante("Chile"));
        Thread hiloBrasil = new Thread(() => GenerarParticipante("Brasil"));

        hiloArgentina.Name = "Selección argentina";
        hiloUruguay.Name = "Selección uruguaya";
        hiloChile.Name = "Seleccion chilena";
        hiloBrasil.Name = "Selección brasilera";

        hiloArgentina.Start();
        hiloUruguay.Start();
        hiloChile.Start();
        hiloBrasil.Start();

        hiloArgentina.Join();
        hiloUruguay.Join();
        hiloChile.Join();
        hiloBrasil.Join();

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

    static void GenerarParticipante(string pais)
    {
        for (int i = 0; i < 4; i++)
        {
            cronometro.Restart();

            cronometro.Start();

            Thread.Sleep(ran.Next(1000, 5000));

            cronometro.Stop();

            TimeSpan tiempoTranscurrido = cronometro.Elapsed;

            Participante participante = participantes.Where(p => p.Pais == pais).ElementAt(i);

            participante.TiempoRegistrado = tiempoTranscurrido;

            Console.WriteLine(
                $"\t> {participante.Nombre} {participante.Apellido} tardó {tiempoTranscurrido.TotalSeconds:F2}s"
            );
        }

        Console.WriteLine($"[{Thread.CurrentThread.Name}] Carrera finalizada.");
    }
}