using Observer.Entidades;
class Program
{
    static List<Pedido> pedidos = new List<Pedido>();
    static Dictionary<int, GestorPedido> gestores = new Dictionary<int, GestorPedido>();
    static List<Notificacion> listaNotificaciones = new List<Notificacion>();
    static List<Logistica> listaLogistica = new List<Logistica>();
    static List<Auditoria> listaAuditoria = new List<Auditoria>();
    static void Main(string[] args)
    {
        InicializarDatos();
        bool salir = false;
        while (!salir)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarNotificacion();
                    break;
                case "2":
                    AgregarLogistica();
                    break;
                case "3":
                    AgregarAuditoria();
                    break;
                case "4":
                    Suscribir();
                    break;
                case "5":
                    Desuscribir();
                    break;
                case "6":
                    CambiarEstadoPedido();
                    break;
                case "7":
                    ListarPedidos();
                    break;
                case "0":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("\nOpción inválida");
                    break;
            }
            if (!salir)
            {
                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
    private static void InicializarDatos()
    {
        Pedido p1 = new Pedido(1, "Bruno", "Pendiente", 1000m);
        Pedido p2 = new Pedido(2, "Eduardo", "Pendiente", 2500m);
        pedidos.Add(p1);
        pedidos.Add(p2);

        gestores[p1.Id] = new GestorPedido(p1);
        gestores[p2.Id] = new GestorPedido(p2);
    }
    private static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("===== MENÚ OBSERVER =====");
        Console.WriteLine("1) Agregar módulo de Notificaciones");
        Console.WriteLine("2) Agregar módulo de Logística");
        Console.WriteLine("3) Agregar módulo de Auditoría");
        Console.WriteLine("4) Suscribir módulo a un pedido");
        Console.WriteLine("5) Desuscribir módulo de un pedido");
        Console.WriteLine("6) Cambiar estado de un pedido");
        Console.WriteLine("7) Listar pedidos");
        Console.WriteLine("0) Salir");
        Console.Write("\nOpción: ");
    }
    private static void AgregarNotificacion()
    {
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Notificación: ");
        string nombre = Console.ReadLine();
        listaNotificaciones.Add(new Notificacion(id, nombre));
        Console.WriteLine("Módulo agregado.");
    }
    private static void AgregarLogistica()
    {
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Logística: ");
        string direccion = Console.ReadLine();
        listaLogistica.Add(new Logistica(id, direccion));
        Console.WriteLine("Módulo agregado.");
    }
    private static void AgregarAuditoria()
    {
        Console.Write("Id de la auditoría: ");
        int id = int.Parse(Console.ReadLine());
        listaAuditoria.Add(new Auditoria(id));
        Console.WriteLine("Módulo agregado.");
    }

    static IObservador ElegirModulo()
    {
        ListarModulos();
        List<IObservador> todos = new List<IObservador>();
        Console.WriteLine("Ingresa el Id del módulo");

        int id = int.Parse(Console.ReadLine());
        IObservador encontrado = listaNotificaciones.FirstOrDefault(x => x.Id == id);
        if (encontrado == null) encontrado = listaLogistica.FirstOrDefault(x => x.Id == id);
        if (encontrado == null) encontrado = listaAuditoria.FirstOrDefault(x => x.Id == id);

        return encontrado;
    }

    static Pedido ElegirPedido()
    {
        ListarPedidos();
        Console.Write("Ingresá el Id del pedido: ");
        int id = int.Parse(Console.ReadLine());
        return pedidos.FirstOrDefault(x => x.Id == id);
    }

    static void Suscribir()
    {
        IObservador obs = ElegirModulo();
        if (obs == null) return;

        Pedido ped = ElegirPedido();
        if (ped == null)
        {
            Console.WriteLine("Pedido no encontrado.");
            return;
        }

        gestores[ped.Id].Suscribir(obs);
        Console.WriteLine($"{obs} suscripto al pedido #{ped.Id}.");
    }

    static void Desuscribir()
    {
        IObservador obs = ElegirModulo();
        if (obs == null) return;

        Pedido ped = ElegirPedido();
        if (ped == null)
        {
            Console.WriteLine("Pedido no encontrado.");
            return;
        }

        gestores[ped.Id].Desuscribir(obs);
        Console.WriteLine($"{obs} desuscripto del pedido #{ped.Id}.");
    }

    static void CambiarEstadoPedido()
    {
        Pedido ped = ElegirPedido();
        if (ped == null)
        {
            Console.WriteLine("Pedido no encontrado.");
            return;
        }

        Console.Write("Nuevo estado: ");
        string estado = Console.ReadLine();
        ped.Estado = estado;

        Console.WriteLine("\n--- Notificaciones disparadas ---");
        gestores[ped.Id].ModificarEstado(ped);
    }

    static void ListarPedidos()
    {
        Console.WriteLine("\n--- Pedidos ---");
        foreach (var p in pedidos)
        {
            Console.WriteLine(p);
        }
    }
    static void ListarModulos()
    {
        Console.WriteLine("\n--- Módulos ---");
        foreach (var e in listaNotificaciones)
        {
            Console.WriteLine(e);
        }
        foreach (var e in listaLogistica)
        {
            Console.WriteLine(e);
        }
        foreach (var e in listaAuditoria)
        {
            Console.WriteLine(e);
        }
    }
}