namespace AbstractFactory.Entidades
{
    public class PanelControlCombustion : IPanelControl
    {
        public void MostrarPanel() => Console.WriteLine("Panel: Nivel de combustible: 3/4 | RPM: 800");
    }
}
