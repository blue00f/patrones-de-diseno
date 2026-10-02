using PracticaHilos;

class Program
{
    static void Main(string[] args)
    {
        List<Participante> participantes = new();
        CargarLista(participantes);
        
        foreach (Participante p in participantes)
        {
            p.Hilo = new Thread(p.Correr);
        }
        for (int i = 0; i < participantes.Count; i++)
        {
            Participante actual = participantes[i];
            if (actual.PosicionEquipo > 1)
            {
                actual.Anterior = participantes.First(p => p.Pais == actual.Pais && p.PosicionEquipo == actual.PosicionEquipo - 1);
            }
        }

        Console.WriteLine("=== Preparados! ===\n");
        foreach (Participante p in participantes)
        {
            p.Hilo.Start();
        }
        foreach (Participante p in participantes)
        {
            p.Hilo.Join();
        }
        Console.WriteLine("\n=== Carrera finalizada! ===");
        MostrarClasificacionPaises(participantes);
        MostrarTop10(participantes);
        Console.ReadKey();
    }
    static void MostrarClasificacionPaises(List<Participante> participantes)
    {
        var consulta = from p in participantes
                     group p by p.Pais into grupo
                     orderby grupo.Sum(x => x.Tiempo)
                     select new
                     {
                         Pais = grupo.Key,
                         TiempoTotal = grupo.Sum(x => x.Tiempo)
                     };

        Console.WriteLine($"\n=== Clasificación países ordenados por tiempo ===");
        foreach (var c in consulta)
        {
            Console.WriteLine($"{c.Pais} - {c.TiempoTotal:F2}s");
        }
    }
    static void MostrarTop10(List<Participante> participantes)
    {
        var consulta = (from p in participantes orderby p.Tiempo select p).Take(10).ToList();

        for (int i = 0; i < consulta.Count; i++)
        {
            consulta[i].PosicionGeneral = i + 1;
        }
        Console.WriteLine("\n=== Top 10 Participantes ===");
        foreach (Participante p in consulta)
        {
            Console.WriteLine($"\t{p.PosicionGeneral} - {p.Nombre} {p.Apellido} {p.Pais.ToUpper()} {p.Tiempo:F2}s");
        }
    }
    static void CargarLista(List<Participante> participantes)
    {
        participantes.Add(new Participante("Juan", "Pérez", "Argentina", 1));
        participantes.Add(new Participante("Pedro", "Gómez", "Argentina", 2));
        participantes.Add(new Participante("Lucas", "Sosa", "Argentina", 3));
        participantes.Add(new Participante("Martín", "Díaz", "Argentina", 4));

        participantes.Add(new Participante("Diego", "López", "Uruguay", 1));
        participantes.Add(new Participante("Andrés", "Suárez", "Uruguay", 2));
        participantes.Add(new Participante("Nicolás", "Silva", "Uruguay", 3));
        participantes.Add(new Participante("Federico", "Pereira", "Uruguay", 4));

        participantes.Add(new Participante("Carlos", "Rojas", "Chile", 1));
        participantes.Add(new Participante("Matías", "Torres", "Chile", 2));
        participantes.Add(new Participante("Felipe", "Vargas", "Chile", 3));
        participantes.Add(new Participante("Tomás", "Muñoz", "Chile", 4));

        participantes.Add(new Participante("João", "Silva", "Brasil", 1));
        participantes.Add(new Participante("Pedro", "Santos", "Brasil", 2));
        participantes.Add(new Participante("Lucas", "Oliveira", "Brasil", 3));
        participantes.Add(new Participante("Rafael", "Costa", "Brasil", 4));
    }
}
