namespace Flyweight.Entidades
{
    public class FabricaTiposArbol
    {
        List<TipoArbol> tiposCreados;
        public FabricaTiposArbol()
        {
            tiposCreados = new List<TipoArbol>();
        }
        public TipoArbol ObtenerTipo(string nombre, string color, string textura)
        {
            TipoArbol? tipo = null;
            foreach (var t in tiposCreados)
            {
                if (t.Nombre == nombre && t.Color == color && t.Textura == textura) tipo = t;
            }
            if (tipo == null)
            {
                tipo = new TipoArbol(nombre, color, textura);
                tiposCreados.Add(tipo);
            }
            return tipo;
        }
        public int CantidadTiposEnMemoria() => tiposCreados.Count;
    }
}
