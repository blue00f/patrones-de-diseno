namespace Flyweight.Entidades
{
    public class Bosque
    {
        List<Arbol> arboles;
        FabricaTiposArbol fabrica;
        public Bosque()
        {
            arboles = new List<Arbol>();
            fabrica = new FabricaTiposArbol();
        }
        public void PlantarArbol(int x, int y, string nombre, string color, string textura)
        {
            TipoArbol tipo = fabrica.ObtenerTipo(nombre, color, textura);
            arboles.Add(new Arbol(x, y, tipo));
        }
        public void DibujarMuestra(int cantidad)
        {
            for (int i=0; i<cantidad && i<arboles.Count; i++)
            {
                arboles[i].Dibujar();
            }
        }
        public void MostrarEstadisticas()
        {
            Console.WriteLine($"\nÁrboles plantados: {arboles.Count}");
            Console.WriteLine($"Tipos de árbol realmente en memoria: {fabrica.CantidadTiposEnMemoria()}");
        }
    }
}
