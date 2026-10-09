namespace Strategy.Entidades
{
    public class ObraSocialBasica : IEstrategiaCobertura
    {
        private const decimal porcentajeCubierto = 0.5m;
        public decimal CalcularMontoAPagar(decimal precioConsulta)
        {
            return precioConsulta - (precioConsulta * porcentajeCubierto);
        }
    }
}
