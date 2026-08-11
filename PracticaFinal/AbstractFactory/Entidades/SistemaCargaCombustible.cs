namespace AbstractFactory.Entidades
{
    public class SistemaCargaCombustible : ISistemaEnergia
    {
        public void Recargar() => Console.WriteLine("Cargando combustible en un surtidor...");
    }
}
