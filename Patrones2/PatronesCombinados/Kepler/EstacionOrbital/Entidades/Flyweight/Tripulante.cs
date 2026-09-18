namespace EstacionOrbital.Entidades.Flyweight
{
    public class Tripulante
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Rango { get; }
        private readonly IEspecie especie;
        public Tripulante(int id, string nombre, string rango, IEspecie especie)
        {
            Id = id;
            Nombre = nombre;
            Rango = rango;
            this.especie = especie;
        }
        public void Mostrar()
        {
            especie.MostrarInfo(Nombre, Id, Rango);
        }
    }
}
