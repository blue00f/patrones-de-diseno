namespace AbstractFactory.Entidades
{
    public class FabricaVehiculoElectrico : IFabricaVehiculo
    {
        public IMotor CrearMotor() => new MotorElectrico();
        public IPanelControl CrearPanelControl() => new PanelControlElectrico();
        public ISistemaEnergia CrearSistemaEnergia() => new SistemaCargaElectrica();
    }
}
