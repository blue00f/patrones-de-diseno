namespace AbstractFactory.Entidades
{
    public class SistemaCargaElectrica : ISistemaEnergia
    {
        public void Recargar() => Console.WriteLine("Cargando batería en un punto de recarga eléctrica...");
    }
}
