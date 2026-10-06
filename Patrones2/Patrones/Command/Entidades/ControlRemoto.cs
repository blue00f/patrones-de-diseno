namespace Command.Entidades
{
    public class ControlRemoto
    {
        private Dictionary<int, IComando> botones;
        private IComando ultimoComandoEjecutado;
        public ControlRemoto()
        {
            botones = new();
        }
        public void AsignarBoton(int numeroBoton, IComando comando)
        {
            botones[numeroBoton] = comando;
        }
        public void PresionarBoton(int numeroBoton)
        {
            if (!botones.ContainsKey(numeroBoton))
            {
                Console.WriteLine($"[Control] El botón {numeroBoton} no tiene nada asignado.");
            }
            else
            {
                Console.WriteLine($"[Control] Botón {numeroBoton} presionado:");
                IComando comando = botones[numeroBoton];
                comando.Ejecutar();
                ultimoComandoEjecutado = comando;
            }
        }
        public void PresionarDeshacer()
        {
            if (ultimoComandoEjecutado == null)
            {
                Console.WriteLine("[Control] No hay nada para deshacer");
            }
            else 
            { 
                Console.WriteLine("[Control] Botón DESHACER presionado:");
                ultimoComandoEjecutado.Deshacer();
            }
        }
    }
}
