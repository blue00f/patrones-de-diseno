namespace Flyweight2.Entidades
{
    public class FabricaEstilos
    {
        private Dictionary<string, EstiloCaracter> estilosCreados;
        public FabricaEstilos()
        {
            estilosCreados = new Dictionary<string, EstiloCaracter>();
        }
        public EstiloCaracter ObtenerEstilo(string fuente, int tamanio, string color, bool negrita)
        {
            EstiloCaracter estilo;
            string clave = $"{fuente}-{tamanio}-{color}-{negrita}";
            if(estilosCreados.TryGetValue(clave, out EstiloCaracter estiloExistente))
            {
                estilo = estiloExistente;
            }
            estilo = new EstiloCaracter(fuente, tamanio, color, negrita);
            estilosCreados[clave] = estilo;
            return estilo;
        }
        public int ObtenerCantidadEstilosEnMemoria() => estilosCreados.Count;
    }
}
