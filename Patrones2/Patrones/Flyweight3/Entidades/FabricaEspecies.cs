namespace Flyweight3.Entidades
{
    public class FabricaEspecies
    {
        Dictionary<string, IEspecie> especiesCreadas;
        public FabricaEspecies()
        {
            especiesCreadas = new();
        }
        public IEspecie ObtenerEspecie(string nombreEspecie, string colorPiel, string planetaOrigen, string dieta)
        {
            IEspecie especie;
            if(especiesCreadas.TryGetValue(nombreEspecie, out IEspecie especieExistente))
            {
                especie = especieExistente;
            }
            especie = new EspecieFlyweight(nombreEspecie, colorPiel, planetaOrigen, dieta);
            especiesCreadas[nombreEspecie] = especie;
            return especie;
        }
        public int CantidadEspeciesEnMemoria() => especiesCreadas.Count;
    }
}
