namespace Strategy.Entidades
{
    public class Prepaga : IEstrategiaCobertura
    {
        private const decimal copagoFijo = 3000m;
        public decimal CalcularMontoAPagar(decimal precioConsulta)
        {
            return Math.Min(precioConsulta, copagoFijo);
        }
    }
}
