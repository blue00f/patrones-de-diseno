using ObserverProxy.Entidades;

public class Program
{
    public static void Main()
    {
        AgendaReal agendaReal = new AgendaReal();
        agendaReal.Suscribir(new NotificadorPaciente());
        agendaReal.Suscribir(new NotificadorMedico());

        IAgenda agenda = new ProxyAgenda(agendaReal);

        Console.WriteLine("> La recepcionista reserva un turno:");
        agenda.ReservarTurno("Recepcionista", "Gandolfi Uriburu");
        Console.WriteLine();

        Console.WriteLine("> Un paciente intenta reservar (no autorizado):");
        agenda.ReservarTurno("Paciente", "Ernesto Acher");
        Console.ReadKey();
    }
}
