using System;
using System.Threading;

namespace EstadoPropiedades
{
    /*
     * Desarrollar un programa que simule el procesamiento de pedidos de un comercio.
     * Cada pedido deberá ejecutarse en un hilo distinto.El sistema deberá mostrar el nombre, prioridad y estado de cada hilo.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROCESAMIENTO DE PEDIDOS ===\n");

            Thread pedidoUno = new Thread(() => ProcesarPedido(101));
            Thread pedidoDos = new Thread(() => ProcesarPedido(102));

            pedidoUno.Name = "Pedido 101";
            pedidoDos.Name = "Pedido 102";

            // La prioridad es una sugerencia para el sistema operativo.
            // No garantiza que un hilo termine antes que otro.
            pedidoUno.Priority = ThreadPriority.AboveNormal;
            pedidoDos.Priority = ThreadPriority.Normal;

            Console.WriteLine($"Nombre: {pedidoUno.Name}");
            Console.WriteLine($"Prioridad: {pedidoUno.Priority}");
            Console.WriteLine($"Está activo antes de Start: {pedidoUno.IsAlive}\n");

            pedidoUno.Start();
            pedidoDos.Start();

            Console.WriteLine($"Está activo después de Start: {pedidoUno.IsAlive}");

            // Esperamos la finalización de los dos pedidos.
            pedidoUno.Join();
            pedidoDos.Join();

            Console.WriteLine($"\nEstado final de {pedidoUno.Name}: {pedidoUno.ThreadState}");
            Console.WriteLine($"Estado final de {pedidoDos.Name}: {pedidoDos.ThreadState}");

            Console.WriteLine("\nTodos los pedidos fueron procesados.");
        }

        static void ProcesarPedido(int numeroPedido)
        {
            Console.WriteLine($"El pedido {numeroPedido} comenzó en el hilo " + $"{Thread.CurrentThread.ManagedThreadId}.");

            for (int etapa = 1; etapa <= 3; etapa++)
            {
                Console.WriteLine($"Pedido {numeroPedido}: etapa {etapa} de 3.");
                Thread.Sleep(600);
            }
            Console.WriteLine($"Pedido {numeroPedido} finalizado.");
        }
    }
}
