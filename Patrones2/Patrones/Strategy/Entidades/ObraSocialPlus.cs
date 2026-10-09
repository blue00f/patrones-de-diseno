namespace Strategy.Entidades
{
    public class ObraSocialPlus : IEstrategiaCobertura
    {
        private const decimal porcentajeCubierto = 0.8m;
        private const decimal topeCobertura = 20000m;
        public decimal CalcularMontoAPagar(decimal precioConsulta)
        {
            decimal cobertura = Math.Min(precioConsulta * porcentajeCubierto, topeCobertura);
            return precioConsulta - cobertura;
        }
    }
}
