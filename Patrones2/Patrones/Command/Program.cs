using Command.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Luz luzCocina = new Luz("Cocina");
        Ventilador ventiladorSala = new Ventilador();
        IComando encenderLuz = new EncenderLuzComando(luzCocina);
        IComando apagarLuz = new ApagarLuzComando(luzCocina);
        IComando encenderVentilador = new EncenderVentiladorComando(ventiladorSala);

        ControlRemoto control = new ControlRemoto();
        control.AsignarBoton(1, encenderLuz);
        control.AsignarBoton(2, apagarLuz);
        control.AsignarBoton(3, encenderVentilador);

        Console.WriteLine("=== Usando el control remoto ===\n");
        control.PresionarBoton(1);
        control.PresionarBoton(3);

        Console.WriteLine("\n=== Deshaciendo la última acción (ventilador) ===");
        control.PresionarDeshacer();

        Console.WriteLine("\n=== Apagando la luz con su propio botón ===");
        control.PresionarBoton(2);

        Console.ReadKey();
    }
}