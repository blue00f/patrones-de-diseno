using System;
using System.Threading.Tasks;

namespace Asincronismo
{
    /*
     * Una aplicación debe descargar tres archivos sin bloquear completamente la ejecución del programa.
     * Desarrollar una solución que represente cada descarga mediante una tarea asincrónica y espere la finalización de todas.
     */
    internal class Program
    {
        // Desde las versiones modernas de C#, Main puede declararse como un método asincrónico.
        static async Task Main(string[] args)
        {
            Console.WriteLine("=== DESCARGA ASINCRÓNICA ===\n");

            // Cada llamada devuelve inmediatamente un objeto Task.
            Task descargaUno = DescargarArchivo("documento.pdf", 3000);
            Task descargaDos = DescargarArchivo("imagen.jpg", 2000);
            Task descargaTres = DescargarArchivo("presentacion.pptx", 4000);
            Console.WriteLine("Las descargas fueron iniciadas.");
            Console.WriteLine("El programa puede realizar otras operaciones.\n");

            // WhenAll espera que todas las tareas finalicen.
            await Task.WhenAll( descargaUno, descargaDos, descargaTres);

            Console.WriteLine("\nTodos los archivos fueron descargados.");
        }

        static async Task DescargarArchivo(string nombreArchivo,int duracion)
        {
            Console.WriteLine($"Iniciando descarga de {nombreArchivo}...");

            //Task.Delay representa una espera asincrónica. A diferencia de Thread.Sleep, no bloquea el hilo mientras transcurre
            //el tiempo.
            await Task.Delay(duracion);

            Console.WriteLine($"Descarga finalizada: {nombreArchivo}.");
        }
    }
}
