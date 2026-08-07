namespace Singleton.Entidades
{
    public class ConfiguracionSistema
    {
        public string NombreEmpresa { get; set; }
        public decimal PorcentajeIva { get; set; }
        public string Moneda { get; set; }

        private static ConfiguracionSistema _instancia;

        private ConfiguracionSistema(string nombreEmpresa, decimal porcentajeIva, string moneda)
        {
            NombreEmpresa = nombreEmpresa;
            PorcentajeIva = porcentajeIva;
            Moneda = moneda;
        }
        public static ConfiguracionSistema ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ConfiguracionSistema("Trululu", 0.20m, "ARS");
            }
            return _instancia;
        }
    }
}
