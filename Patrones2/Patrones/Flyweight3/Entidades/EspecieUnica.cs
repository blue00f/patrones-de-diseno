namespace Flyweight3.Entidades
{
    public class EspecieUnica : IEspecie
    {
        public string NombreEspecie { get; set; }
        public string ColorPiel { get; set; }
        public string PlanetaOrigen { get; set; }
        public string Dieta { get; set; }
        public string ObservacionParticular { get; set; }

        public EspecieUnica(string nombreEspecie, string colorPiel, string planetaOrigen, string dieta, string observacionParticular)
        {
            this.NombreEspecie = nombreEspecie;
            this.ColorPiel = colorPiel;
            this.PlanetaOrigen = planetaOrigen;
            this.Dieta = dieta;
            this.ObservacionParticular = observacionParticular;
        }

        public void MostrarInfo(string nombreTripulante, int id, string rango)
        {
            Console.WriteLine($"{nombreTripulante} (ID: {id}, {rango}) | Especie: {NombreEspecie} [ÚNICA] | Piel: {ColorPiel} | Origen: {PlanetaOrigen} | Dieta: {Dieta} | Nota: {ObservacionParticular}");
        }
    }
}
