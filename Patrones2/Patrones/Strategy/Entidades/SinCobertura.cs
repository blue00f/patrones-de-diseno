namespace Strategy.Entidades
{
    public class SinCobertura : IEstrategiaCobertura
    {
        public decimal CalcularMontoAPagar(decimal precioConsulta)
        {
            return precioConsulta;
        }
    }
}
