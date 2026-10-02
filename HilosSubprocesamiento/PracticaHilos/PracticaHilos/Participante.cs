using System.Diagnostics;

namespace PracticaHilos
{
    public class Participante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Pais { get; set; }
        public double Tiempo { get; set; }
        public int PosicionEquipo { get; set; }
        public int PosicionGeneral { get; set; }
        public Thread Hilo { get; set; }
        public Participante Anterior { get; set; }
        public Participante(string nombre, string apellido, string pais, int posicionEquipo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Pais = pais;
            PosicionEquipo = posicionEquipo;
        }

        public void Correr()
        {
            if (Anterior != null)
            {
                Anterior.Hilo.Join();
            }
            Stopwatch cronometro = Stopwatch.StartNew();
            int duracion = Random.Shared.Next(1000, 5001);
            Thread.Sleep(duracion);
            cronometro.Stop();
            this.Tiempo = cronometro.Elapsed.TotalSeconds;
            Console.WriteLine($"{Pais} - Participante {PosicionEquipo} terminó en {Tiempo:F2}s");
        }
    }
}
