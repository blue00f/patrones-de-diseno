using Singleton.Entidades;

class Program
{
    static void Main(string[] args)
    {
        ConfiguracionSistema config1 = ConfiguracionSistema.ObtenerInstancia();
        Console.WriteLine($"Configuración del sistema\nEmpresa: {config1.NombreEmpresa}\nIVA: {config1.PorcentajeIva:N2}\nMoneda: {config1.Moneda}");

        ConfiguracionSistema config2 = ConfiguracionSistema.ObtenerInstancia();
        Console.WriteLine($"Configuración del sistema\nEmpresa: {config2.NombreEmpresa}\nIVA: {config2.PorcentajeIva:N2}\nMoneda: {config2.Moneda}");

    }
}