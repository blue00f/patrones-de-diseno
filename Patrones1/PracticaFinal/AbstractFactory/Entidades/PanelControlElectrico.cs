namespace AbstractFactory.Entidades
{
    public class PanelControlElectrico : IPanelControl
    {
        public void MostrarPanel() => Console.WriteLine("Panel: 87% de batería | Autonomía estimada: 320 km");
    }
}
