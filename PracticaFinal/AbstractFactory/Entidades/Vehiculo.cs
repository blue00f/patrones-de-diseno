namespace AbstractFactory.Entidades
{
    public class Vehiculo
    {
        private IMotor motor;
        private IPanelControl panel;
        private ISistemaEnergia sistemaEnergia;
        public Vehiculo(IMotor motor, IPanelControl panel, ISistemaEnergia sistemaEnergia)
        {
            this.motor = motor;
            this.panel = panel;
            this.sistemaEnergia = sistemaEnergia;
        }
        public void Armar()
        {
            motor.Arrancar();
            panel.MostrarPanel();
            sistemaEnergia.Recargar();
        }
    }
}
