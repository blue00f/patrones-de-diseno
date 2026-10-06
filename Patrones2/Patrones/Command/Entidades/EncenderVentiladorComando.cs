namespace Command.Entidades
{
    public class EncenderVentiladorComando : IComando
    {
        private Ventilador ventilador;
        public EncenderVentiladorComando(Ventilador ventilador)
        {
            this.ventilador = ventilador;
        }
        public void Ejecutar() => ventilador.Encender();
        public void Deshacer() => ventilador.Apagar();

    }
}
