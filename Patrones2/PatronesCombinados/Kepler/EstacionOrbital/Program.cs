using EstacionOrbital.Entidades.Bridge;
using EstacionOrbital.Entidades.Facade;
using EstacionOrbital.Entidades.Flyweight;
using EstacionOrbital.Entidades.Proxy;

class Program
{
    private static readonly FabricaEspecies fabrica = new FabricaEspecies();
    public static void Main()
    {
        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            CargarMenu();
            string opcion = Console.ReadLine();
            Console.WriteLine();
            switch (opcion)
            {
                case "1": CargarMisionPuente(); break;
                case "2": CargarModuloControl(); break;
                case "3": CargarBibliotecaTripulantes(); break;
                case "4": CargarAccesoBoveda(); break;
                case "0": salir = true; break;
                default: MostrarTitulo("Opción inválida.", ConsoleColor.DarkRed, ConsoleColor.White); break;
            }
            if (!salir) CargarSalidaDeMenu();
        }
    }
    private static void CargarMisionPuente()
    {
        MostrarTitulo("MISIÓN 1: PUENTE DE COMUNICACIONES", ConsoleColor.Yellow, ConsoleColor.Black);

        List<Mensaje> mensajes = new List<Mensaje>
            {
                new MensajeTexto(new SinCifrado(), "Reporte diario sin novedades"),
                new MensajeAlerta(new CifradoAES(), "Tormenta solar en 2 horas"),
                new MensajeEmergencia(new CifradoCuantico(), "Brecha en el casco del módulo 3")
            };
        foreach (Mensaje mensaje in mensajes)
        {
            mensaje.Enviar();
            Console.WriteLine();
        }
    }
    private static void CargarModuloControl()
    {
        MostrarTitulo("MISIÓN 2: MÓDULO DE CONTROL CENTRAL", ConsoleColor.Gray, ConsoleColor.Black);
        ControlCentral control = new ControlCentral();
        control.IniciarTurno();

        Console.WriteLine("\n[Presione ENTER para simular una falla en los sistemas...]");
        Console.ReadLine();
        control.EntrarEnEmergencia();

        Console.WriteLine("\n[Presione ENTER para iniciar el protocolo de evacuación y apagado...]");
        Console.ReadLine();
        control.ApagarEstacion();
    }
    private static void CargarBibliotecaTripulantes()
    {
        MostrarTitulo("MISIÓN 3: BIBLIOTECA DE TRIPULANTES", ConsoleColor.DarkGray, ConsoleColor.White);
        string[] nombresEspecies = { "Humano", "Andoriano", "Vulcaniano", "Klingon", "Ferengi" };
        string[] rangos = { "Cadete", "Teniente", "Comandante", "Ingeniero", "Médico" };
        Random random = new Random();

        List<Tripulante> tripulacion = new List<Tripulante>();
        for (int i = 1; i <= 10000; i++)
        {
            string especieElegida = nombresEspecies[random.Next(nombresEspecies.Length)];
            IEspecie especie = fabrica.ObtenerEspecie(especieElegida);
            string rango = rangos[random.Next(rangos.Length)];

            tripulacion.Add(new Tripulante(i, "Tripulante-" + i, rango, especie));
        }
        Console.WriteLine("Primeros 5 tripulantes:");
        for (int i = 0; i < 5; i++)
        {
            tripulacion[i].Mostrar();
        }

        Console.WriteLine();
        Console.WriteLine($"Tripulantes creados: {tripulacion.Count}");
        Console.WriteLine($"Objetos EspecieFlyweight creados: {EspecieFlyweight.CantidadCreadas}");
        Console.WriteLine($"Especies en la fábrica: {fabrica.ObtenerCantidadEspeciesEnMemoria()}");
    }

    private static void CargarAccesoBoveda()
    {
        MostrarTitulo("MISIÓN 4: ACCESO A LA BÓVEDA DE DATOS", ConsoleColor.Blue, ConsoleColor.White);
        IBoveda accesoCapitan = new ProxyBoveda("Kirk", "Capitan");
        IBoveda accesoSeguridad = new ProxyBoveda("Worf", "OficialSeguridad");
        IBoveda accesoCocinero = new ProxyBoveda("Neelix", "Cocinero");

        accesoCapitan.LeerArchivo("A-001");
        Console.WriteLine();
        accesoSeguridad.EscribirArchivo("A-003", "Informe de brecha de seguridad");
        Console.WriteLine();
        accesoCocinero.LeerArchivo("A-002");
        Console.WriteLine();
        accesoCocinero.EscribirArchivo("A-002", "Receta secreta");
    }
    private static void MostrarTitulo(string textoTitulo, ConsoleColor colorFondo, ConsoleColor colorTexto)
    {
        Console.BackgroundColor = colorFondo;
        Console.ForegroundColor = colorTexto;
        Console.WriteLine($"--- {textoTitulo} ---");
        Console.ResetColor();
    }
    private static void CargarMenu()
    {
        Console.WriteLine("===== ESTACIÓN ORBITAL KEPLER-7 =====");
        Console.WriteLine("1. Misión 1 - Puente de Comunicaciones (Bridge)");
        Console.WriteLine("2. Misión 2 - Control Central (Facade)");
        Console.WriteLine("3. Misión 3 - Biblioteca de Tripulantes (Flyweight)");
        Console.WriteLine("4. Misión 4 - Bóveda de Datos (Proxy)");
        Console.WriteLine("0. Salir");
        Console.Write("Opción: ");
    }
    private static void CargarSalidaDeMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Presione ENTER para continuar...");
        Console.ReadLine();
    }
}