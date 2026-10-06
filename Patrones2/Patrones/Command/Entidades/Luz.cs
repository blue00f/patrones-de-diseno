namespace Command.Entidades
{
    public class Luz
    {
        public string Habitacion { get; }
        public Luz(string habitacion)
        {
            Habitacion = habitacion;
        }
        public void Encender() => Console.WriteLine($"\tLa luz de '{Habitacion}' está ENCENDIDA");
        public void Apagar() => Console.WriteLine($"\tLa luz de '{Habitacion}' está APAGADA");
    }
}
