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
            if(especiesCreadas.TryGetValue(nombreEspecie, out IEspecie especieExistente))
            {
                return especieExistente;
            }
            IEspecie nuevaEspecie = new EspecieFlyweight(nombreEspecie, colorPiel, planetaOrigen, dieta);
            especiesCreadas[nombreEspecie] = nuevaEspecie;
            return nuevaEspecie;
        }
        public int CantidadEspeciesEnMemoria() => especiesCreadas.Count;
    }
}
