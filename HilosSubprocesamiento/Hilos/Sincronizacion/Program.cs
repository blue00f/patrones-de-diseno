using System;
using System.Threading;

namespace Sincronizacion
{
    /*
     * Una cuenta bancaria posee un saldo inicial de $10.000. Dos personas realizan extracciones simultáneas desde diferentes terminales.
     * Desarrollar un programa que sincronice el acceso al saldo para evitar que ambos hilos lo modifiquen al mismo tiempo.
     */
    internal class Program
    {
        // Recurso compartido por los diferentes hilos.
        static decimal saldo = 10000;

        // Objeto utilizado para sincronizar el acceso al saldo.
        static readonly object bloqueoSaldo = new object();

        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA BANCARIO ===");
            Console.WriteLine($"Saldo inicial: {saldo:C}\n");

            Thread terminalUno = new Thread(() => ExtraerDinero("Terminal 1", 3000));
            Thread terminalDos = new Thread(() => ExtraerDinero("Terminal 2", 8000));

            terminalUno.Start();
            terminalDos.Start();

            terminalUno.Join();
            terminalDos.Join();

            Console.WriteLine($"\nSaldo final: {saldo:C}");
        }

        static void ExtraerDinero(string terminal, decimal importe)
        {
            Console.WriteLine($"{terminal} solicita una extracción de {importe:C}.");

            // lock permite que solamente un hilo por vez acceda al bloque de código que modifica el saldo.
            lock (bloqueoSaldo)
            {
                Console.WriteLine($"{terminal} está verificando el saldo...");

                // Simula el tiempo necesario para consultar la cuenta.
                Thread.Sleep(1000);

                if (saldo >= importe)
                {
                    saldo -= importe;

                    Console.WriteLine($"{terminal}: extracción realizada.");

                    Console.WriteLine($"{terminal}: nuevo saldo {saldo:C}.");
                }
                else
                {
                    Console.WriteLine($"{terminal}: saldo insuficiente.");
                }
            }
        }
    }
}
