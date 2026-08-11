using AbstractFactory.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Vehículo Eléctrico ===");
        Vehiculo vehiculoElectrico = ArmarVehiculo(new FabricaVehiculoElectrico());
        vehiculoElectrico.Armar();

        Console.WriteLine("\n=== Vehículo a Combustión ===");
        Vehiculo vehiculoCombustion = ArmarVehiculo(new FabricaVehiculoCombustion());
        vehiculoCombustion.Armar();

        Console.ReadKey();
    }
    private static Vehiculo ArmarVehiculo(IFabricaVehiculo fabrica)
    {
        IMotor motor = fabrica.CrearMotor();
        IPanelControl panel = fabrica.CrearPanelControl();
        ISistemaEnergia sistemaEnergia = fabrica.CrearSistemaEnergia();
        return new Vehiculo(motor, panel, sistemaEnergia);
    }
}