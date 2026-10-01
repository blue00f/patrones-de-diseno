namespace Flyweight3.Entidades
{
    public class EspecieFlyweight : IEspecie
    {
        private string NombreEspecie { get; }
        private string ColorPiel { get; }
        private string PlanetaOrigen { get; }
        private string Dieta { get; }
        public EspecieFlyweight(string nombreEspecie, string colorPiel, string planetaOrigen, string dieta)
        {
            this.NombreEspecie = nombreEspecie;
            this.ColorPiel = colorPiel;
            this.PlanetaOrigen = planetaOrigen;
            this.Dieta = dieta;
        }
        public void MostrarInfo(string nombreTripulante, int id, string rango)
        {
            Console.WriteLine($"{nombreTripulante} (ID: {id}, {rango}) | Especie: {NombreEspecie} | Piel: {ColorPiel} | Origen: {PlanetaOrigen} | Dieta: {Dieta}");
        }
    }
}
