using System;
using System.Collections.Generic;
using System.Globalization;
using PresupuestosPatrones.Builders;
using PresupuestosPatrones.Modelos;

namespace PresupuestosPatrones
{
    class Program
    {
        private static readonly PresupuestoResumidoBuilder builderResumido = new PresupuestoResumidoBuilder();
        private static readonly PresupuestoDetalladoBuilder builderDetallado = new PresupuestoDetalladoBuilder();
        private static readonly Director director = new Director(builderResumido);

        private static readonly List<PresupuestoResumido> resumidos = new List<PresupuestoResumido>();
        private static readonly List<PresupuestoDetallado> detallados = new List<PresupuestoDetallado>();

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("===== SISTEMA DE PRESUPUESTOS =====");
                Console.WriteLine("1. Crear presupuesto resumido");
                Console.WriteLine("2. Crear presupuesto detallado");
                Console.WriteLine("3. Ver presupuestos creados");
                Console.WriteLine("4. Clonar un presupuesto");
                Console.WriteLine("0. Salir");
                string opcion = LeerTexto("\nOpcion: ");

                switch (opcion)
                {
                    case "1":
                        CrearResumido();
                        break;
                    case "2":
                        CrearDetallado();
                        break;
                    case "3":
                        VerPresupuestos();
                        break;
                    case "4":
                        ClonarPresupuesto();
                        break;
                    case "0":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione una tecla para volver al menu...");
                    Console.ReadKey(true);
                }
            }
        }

        static void CrearResumido()
        {
            Console.WriteLine("\n--- NUEVO PRESUPUESTO RESUMIDO ---");
            string nombre = LeerTextoObligatorio("Nombre del cliente: ");
            string apellido = LeerTextoObligatorio("Apellido del cliente: ");
            List<string> items = LeerItems();
            string condicionPago = LeerTextoObligatorio("Condicion de pago: ");

            director.CambiarBuilder(builderResumido);
            director.ConstruirPresupuesto(nombre, apellido, items, condicionPago);
            PresupuestoResumido presupuesto = builderResumido.ObtenerPresupuesto();
            resumidos.Add(presupuesto);

            Console.WriteLine("\nPresupuesto creado:\n");
            Console.WriteLine(presupuesto.Mostrar());
        }

        static void CrearDetallado()
        {
            Console.WriteLine("\n--- NUEVO PRESUPUESTO DETALLADO ---");
            string nombre = LeerTextoObligatorio("Nombre del cliente: ");
            string apellido = LeerTextoObligatorio("Apellido del cliente: ");
            List<string> items = LeerItems();
            string condicionPago = LeerTextoObligatorio("Condicion de pago: ");
            decimal descuento = LeerDescuento("Descuento % (Enter si no tiene): ", 0);
            string notaFinal = LeerTexto("Nota final (Enter si no tiene): ");

            director.CambiarBuilder(builderDetallado);
            director.ConstruirPresupuesto(nombre, apellido, items, condicionPago, descuento, notaFinal);
            PresupuestoDetallado presupuesto = builderDetallado.ObtenerPresupuesto();
            detallados.Add(presupuesto);

            Console.WriteLine("\nPresupuesto creado:\n");
            Console.WriteLine(presupuesto.Mostrar());
        }

        static void VerPresupuestos()
        {
            if (resumidos.Count == 0 && detallados.Count == 0)
            {
                Console.WriteLine("\nTodavia no hay presupuestos creados.");
            }
            else
            {
                for (int i = 0; i < resumidos.Count; i++)
                {
                    Console.WriteLine($"\n[Resumido #{i + 1}]");
                    Console.WriteLine(resumidos[i].Mostrar());
                }

                for (int i = 0; i < detallados.Count; i++)
                {
                    Console.WriteLine($"\n[Detallado #{i + 1}]");
                    Console.WriteLine(detallados[i].Mostrar());
                }
            }
        }

        static void ClonarPresupuesto()
        {
            if (resumidos.Count == 0 && detallados.Count == 0)
            {
                Console.WriteLine("\nNo hay presupuestos para clonar. Cree uno primero.");
            }
            else
            {
                Console.WriteLine("\n--- CLONAR PRESUPUESTO ---");
                Console.WriteLine("1. Resumido");
                Console.WriteLine("2. Detallado");
                string tipo = LeerTexto("Tipo: ");

                if (tipo == "1")
                {
                    ClonarResumido();
                }
                else if (tipo == "2")
                {
                    ClonarDetallado();
                }
                else
                {
                    Console.WriteLine("Opcion invalida.");
                }
            }
        }

        static void ClonarResumido()
        {
            if (resumidos.Count == 0)
            {
                Console.WriteLine("No hay presupuestos resumidos creados.");
            }
            else
            {
                for (int i = 0; i < resumidos.Count; i++)
                {
                    PresupuestoResumido p = resumidos[i];
                    Console.WriteLine($"{i + 1}. {p.NombreCliente} {p.ApellidoCliente} - {p.Items.Count} item(s)");
                }

                int indice = LeerIndice(resumidos.Count);
                PresupuestoResumido original = resumidos[indice];

                PresupuestoResumido copia = original.Clonar();

                Console.WriteLine("\nPresupuesto clonado. Modifique lo que cambia (Enter mantiene el valor):");
                copia.NombreCliente = LeerTextoConDefault("Nombre", copia.NombreCliente);
                copia.ApellidoCliente = LeerTextoConDefault("Apellido", copia.ApellidoCliente);
                copia.CondicionPago = LeerTextoConDefault("Condicion de pago", copia.CondicionPago);
                AgregarItemsExtra(copia.Items);

                resumidos.Add(copia);

                MostrarComparacion(original.Mostrar(), copia.Mostrar(),
                                   ReferenceEquals(original, copia),
                                   ReferenceEquals(original.Items, copia.Items));
            }
        }

        static void ClonarDetallado()
        {
            if (detallados.Count == 0)
            {
                Console.WriteLine("No hay presupuestos detallados creados.");
            }
            else
            {
                for (int i = 0; i < detallados.Count; i++)
                {
                    PresupuestoDetallado p = detallados[i];
                    Console.WriteLine($"{i + 1}. {p.NombreCliente} {p.ApellidoCliente} - {p.Items.Count} item(s)");
                }

                int indice = LeerIndice(detallados.Count);
                PresupuestoDetallado original = detallados[indice];

                PresupuestoDetallado copia = original.Clonar();

                Console.WriteLine("\nPresupuesto clonado. Modifique lo que cambia (Enter mantiene el valor):");
                copia.NombreCliente = LeerTextoConDefault("Nombre", copia.NombreCliente);
                copia.ApellidoCliente = LeerTextoConDefault("Apellido", copia.ApellidoCliente);
                copia.CondicionPago = LeerTextoConDefault("Condicion de pago", copia.CondicionPago);
                copia.Descuento = LeerDescuento($"Descuento % [{copia.Descuento}]: ", copia.Descuento);
                copia.NotaFinal = LeerTextoConDefault("Nota final", copia.NotaFinal);
                AgregarItemsExtra(copia.Items);

                detallados.Add(copia);

                MostrarComparacion(original.Mostrar(), copia.Mostrar(),
                                   ReferenceEquals(original, copia),
                                   ReferenceEquals(original.Items, copia.Items));
            }
        }

        static void MostrarComparacion(string textoOriginal, string textoCopia, bool mismoObjeto, bool mismaLista)
        {
            Console.WriteLine("\n############ ORIGINAL ############");
            Console.WriteLine(textoOriginal);
            Console.WriteLine("############## CLON ##############");
            Console.WriteLine(textoCopia);

            Console.WriteLine("--- Verificacion del Prototype ---");
            Console.WriteLine($"Original y clon son el mismo objeto?    {(mismoObjeto ? "SI" : "NO")}");
            Console.WriteLine($"Comparten la misma lista de items?      {(mismaLista ? "SI" : "NO")}");

            if (!mismoObjeto && !mismaLista)
            {
                Console.WriteLine("El clon es independiente: los cambios no afectaron al original.");
            }
        }

        static string LeerTexto(string mensaje)
        {
            Console.Write(mensaje);
            string texto = (Console.ReadLine() ?? "").Trim();
            return texto;
        }

        static string LeerTextoObligatorio(string mensaje)
        {
            string texto = LeerTexto(mensaje);
            while (texto == "")
            {
                Console.WriteLine("  Este dato es obligatorio.");
                texto = LeerTexto(mensaje);
            }
            return texto;
        }

        static string LeerTextoConDefault(string etiqueta, string valorActual)
        {
            string resultado = valorActual;
            string texto = LeerTexto($"{etiqueta} [{valorActual}]: ");
            if (texto != "")
            {
                resultado = texto;
            }
            return resultado;
        }

        static List<string> LeerItems()
        {
            List<string> items = new List<string>();
            Console.WriteLine("Items (Enter vacio para terminar):");
            bool terminar = false;

            while (!terminar)
            {
                string item = LeerTexto($"  Item {items.Count + 1}: ");
                if (item != "")
                {
                    items.Add(item);
                }
                else if (items.Count == 0)
                {
                    Console.WriteLine("  Tiene que haber al menos un item.");
                }
                else
                {
                    terminar = true;
                }
            }
            return items;
        }

        static void AgregarItemsExtra(List<string> items)
        {
            Console.WriteLine("Agregar items al clon (Enter vacio para terminar):");
            bool terminar = false;

            while (!terminar)
            {
                string item = LeerTexto($"  Item {items.Count + 1}: ");
                if (item != "")
                {
                    items.Add(item);
                }
                else
                {
                    terminar = true;
                }
            }
        }

        static decimal LeerDescuento(string mensaje, decimal valorPorDefecto)
        {
            decimal resultado = valorPorDefecto;
            bool valido = false;

            while (!valido)
            {
                string texto = LeerTexto(mensaje).Replace(',', '.');
                if (texto == "")
                {
                    valido = true;
                }
                else if (decimal.TryParse(texto, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal valor)
                         && valor <= 100)
                {
                    resultado = valor;
                    valido = true;
                }
                else
                {
                    Console.WriteLine("  Ingrese un numero entre 0 y 100.");
                }
            }
            return resultado;
        }

        static int LeerIndice(int cantidad)
        {
            int indice = -1;

            while (indice == -1)
            {
                string texto = LeerTexto("Numero de presupuesto: ");
                if (int.TryParse(texto, out int numero) && numero >= 1 && numero <= cantidad)
                {
                    indice = numero - 1;
                }
                else
                {
                    Console.WriteLine($"  Ingrese un numero entre 1 y {cantidad}.");
                }
            }
            return indice;
        }
    }
}