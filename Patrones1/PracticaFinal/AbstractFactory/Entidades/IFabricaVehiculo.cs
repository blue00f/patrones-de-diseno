namespace AbstractFactory.Entidades
{
    public interface IFabricaVehiculo
    {
        IMotor CrearMotor();
        IPanelControl CrearPanelControl();
        ISistemaEnergia CrearSistemaEnergia();
    }
}
