namespace EstacionOrbital.Entidades.Flyweight
{
    public class FabricaEspecies
    {
        private readonly Dictionary<string, IEspecie> especies;
        public FabricaEspecies()
        {
            especies = new();
        }
        public IEspecie ObtenerEspecie(string nombre)
        {
            if (!especies.ContainsKey(nombre))
            {
                especies[nombre] = CrearEspecie(nombre);
            }
            IEspecie especie = especies[nombre];
            return especie;
        }
        private IEspecie CrearEspecie(string nombre)
        {
            IEspecie especie = nombre switch
            {
                "Humano" => new EspecieFlyweight("Humano", "variada", "Tierra", "omnívora"),
                "Andoriano" => new EspecieFlyweight("Andoriano", "azul", "Andoria", "carnívora"),
                "Vulcaniano" => new EspecieFlyweight("Vulcaniano", "verdosa pálida", "Vulcano", "vegetariana"),
                "Klingon" => new EspecieFlyweight("Klingon", "marrón rojiza", "Qo'noS", "carnívora"),
                "Ferengi" => new EspecieFlyweight("Ferengi", "anaranjada", "Ferenginar", "insectos"),
                _ => throw new ArgumentException($"Especie desconocida: {nombre}")
            };
            return especie;
        }
        public int ObtenerCantidadEspeciesEnMemoria() => especies.Count;
    }
}
