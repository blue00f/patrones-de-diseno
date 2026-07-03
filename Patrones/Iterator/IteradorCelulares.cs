namespace Iterator
{
    public class IteradorCelulares : IIterador
    {
        CatalogoCelulares catalogo;
        int posicion;
        public IteradorCelulares(CatalogoCelulares cat)
        {
            catalogo = cat;
            posicion = 0;
        }
        public void Primero()
        {
            posicion = 0;
        }
        public void Siguiente()
        {
            posicion++;
        }
        public bool HaySiguiente()
        {
            return posicion < catalogo.Cantidad();
        }
        public Celular Actual()
        {
            return catalogo.Obtener(posicion);
        }
    }
}
