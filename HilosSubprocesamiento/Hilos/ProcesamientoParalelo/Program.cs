using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ProcesamientoParalelo
{
    /*
     * Un comercio necesita calcular el precio final de varios productos aplicando un IVA del 21 %.
     * Desarrollar un programa que procese la lista en paralelo y muestre qué hilo realizó cada cálculo.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CÁLCULO PARALELO DE PRECIOS ===\n");

            List<Producto> productos = new List<Producto>
            {
                new Producto("Teclado", 25000),
                new Producto("Mouse", 15000),
                new Producto("Monitor", 180000),
                new Producto("Impresora", 220000),
                new Producto("Auriculares", 45000),
                new Producto("Webcam", 60000)
            };

            // Parallel.ForEach distribuye los elementos entre diferentes hilos disponibles administrados por .NET.
            Parallel.ForEach(productos, producto => { CalcularPrecioFinal(producto);});

            Console.WriteLine("\nTodos los precios fueron calculados.");
        }
        static void CalcularPrecioFinal(Producto producto)
        {
            // Simula un cálculo que requiere tiempo.
            Thread.Sleep(800);

            decimal precioFinal = producto.Precio * 1.21m;

            Console.WriteLine( $"Hilo {Thread.CurrentThread.ManagedThreadId}: " + $"{producto.Nombre} - Precio final: {precioFinal:C}");
        }
    }

    /// <summary>
    /// Representa un producto que debe ser procesado.
    /// </summary>
    internal class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
