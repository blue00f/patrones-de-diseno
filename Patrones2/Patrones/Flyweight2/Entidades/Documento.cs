using System.Globalization;

namespace Flyweight2.Entidades
{
    public class Documento
    {
        private List<CaracterDocumento> caracteres;
        private FabricaEstilos fabrica;
        private int posicionActual = 0;
        public Documento()
        {
            caracteres = new List<CaracterDocumento>();
            fabrica = new FabricaEstilos();
        }
        public void Escribir(string texto, string fuente, int tamanio, string color, bool negrita)
        {
            EstiloCaracter estilo = fabrica.ObtenerEstilo(fuente, tamanio, color, negrita);
            foreach (char letra in texto)
            {
                caracteres.Add(new CaracterDocumento(letra, posicionActual, estilo));
                posicionActual++;
            }
        }
        public void Renderizar()
        {
            foreach (var caracter in caracteres)
            {
                caracter.Renderizar();
            }
            Console.WriteLine();
        }
        public void MostrarEstadisticas()
        {
            Console.WriteLine($"\nCaracteres totales en el documento: {caracteres.Count}");
            Console.WriteLine($"Estilos realmente creados en memoria: {fabrica.ObtenerCantidadEstilosEnMemoria()}");
        }
    }
}
