namespace AbstractFactory.Entidades
{
    public class FabricaVehiculoCombustion : IFabricaVehiculo
    {
        public IMotor CrearMotor() => new MotorCombustion();
        public IPanelControl CrearPanelControl() => new PanelControlCombustion();
        public ISistemaEnergia CrearSistemaEnergia() => new SistemaCargaCombustible();
    }
}
