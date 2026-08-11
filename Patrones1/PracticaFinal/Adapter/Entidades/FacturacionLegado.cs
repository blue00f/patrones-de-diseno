namespace Adapter.Entidades
{
    public class FacturacionLegado
    {
        public void GenerarFactura(string cliente, int totalEnCentavos, string codigoMoneda)
        {
            Console.WriteLine($"[Sistema legacy]\nFactura generada para {cliente}: {totalEnCentavos} centavos {codigoMoneda}");
        }
    }
}
