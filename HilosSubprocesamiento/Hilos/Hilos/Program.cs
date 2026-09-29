using System;
using System.Threading;

namespace Hilos
{
    /*
     * Una empresa necesita procesar simultáneamente dos tareas: generar un reporte de ventas y realizar una copia de seguridad.
     * Desarrollar un programa que ejecute cada tarea en un hilo independiente y muestre su progreso.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE PROCESAMIENTO ===");
            Console.WriteLine("Hilo principal iniciado.\n");

            // Se crean dos hilos y se les asigna un método.
            Thread hiloReporte = new Thread(GenerarReporte);
            Thread hiloCopiaSeguridad = new Thread(RealizarCopiaSeguridad);

            // Se asigna un nombre identificador a cada hilo.
            hiloReporte.Name = "Hilo de reportes";
            hiloCopiaSeguridad.Name = "Hilo de copia de seguridad";

            // Start inicia la ejecución de los hilos.
            hiloReporte.Start();
            hiloCopiaSeguridad.Start();

            // Join detiene el hilo principal hasta que ambos hilos terminen.
            hiloReporte.Join();
            hiloCopiaSeguridad.Join();

            Console.WriteLine("\nTodas las tareas finalizaron.");
            Console.WriteLine("Hilo principal terminado.");
        }

        static void GenerarReporte()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"[{Thread.CurrentThread.Name}] Procesando sección {i} de 5...");

                // Simula una operación que demora 700 milisegundos.
                Thread.Sleep(700);
            }
            Console.WriteLine($"[{Thread.CurrentThread.Name}] Reporte generado.");
        }

        static void RealizarCopiaSeguridad()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"[{Thread.CurrentThread.Name}] Copiando archivo {i} de 5...");
                Thread.Sleep(500);
            }
            Console.WriteLine($"[{Thread.CurrentThread.Name}] Copia de seguridad finalizada.");
        }
    }
}
