namespace Command.Entidades
{
    public class Ventilador
    {
        public int Velocidad { get; private set; } = 0;
        public void Encender()
        {
            Velocidad = 3;
            Console.WriteLine($"\tEl ventilador gira a velocidad {Velocidad}");
        }
        public void Apagar()
        {
            Velocidad = 0;
            Console.WriteLine($"\tEl ventilador se detuvo");
        }
    }
}
