namespace ObserverProxy.Entidades
{
    public class ProxyAgenda : IAgenda
    {
        private readonly AgendaReal _agendaReal;
        public ProxyAgenda(AgendaReal agendaReal)
        {
            _agendaReal = agendaReal;
        }
        public void ReservarTurno(string rol, string paciente)
        {
            if (rol == "Recepcionista")
            {
                _agendaReal.ReservarTurno(rol, paciente);
            }
            else
            {
                Console.WriteLine("Acceso denegado: el rol '" + rol + "' no puede reservar turnos.");
            }
        }
    }
}
