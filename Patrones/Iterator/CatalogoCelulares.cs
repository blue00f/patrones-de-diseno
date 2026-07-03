namespace Iterator
{
    public class CatalogoCelulares : IColeccion
    {
        List<Celular> celulares;
        public CatalogoCelulares()
        {
            celulares = new List<Celular>();
        }
        public void Agregar(Celular celular) => celulares.Add(celular);
        public Celular Obtener(int i) => celulares[i];
        public int Cantidad() => celulares.Count;

        public IIterador CrearIterador()
        {
            return new IteradorCelulares(this);
        }
    }
}
