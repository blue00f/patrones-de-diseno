namespace EstacionOrbital.Entidades.Flyweight
{
    public class EspecieFlyweight : IEspecie
    {
        private readonly string nombreEspecie;
        private readonly string colorPiel;
        private readonly string planetaOrigen;
        private readonly string dieta;
        public static int CantidadCreadas { get; private set; } = 0;
        public EspecieFlyweight(string nombreEspecie, string colorPiel, string planetaOrigen, string dieta)
        {
            this.nombreEspecie = nombreEspecie;
            this.colorPiel = colorPiel;
            this.planetaOrigen = planetaOrigen;
            this.dieta = dieta;
            CantidadCreadas++;
        }
        public void MostrarInfo(string nombre, int id, string rango)
        {
            Console.WriteLine($"  #{id} {nombre} ({rango}) - {nombreEspecie}, piel {colorPiel}, de {planetaOrigen}, dieta {dieta}");
        }
    }
}
