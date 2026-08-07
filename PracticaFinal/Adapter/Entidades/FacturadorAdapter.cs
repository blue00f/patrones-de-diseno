namespace Adapter.Entidades
{
    public class FacturadorAdapter : IFacturador
    {
        FacturacionLegado facturacionLegado;
        public FacturadorAdapter(FacturacionLegado facturacionLegado)
        {
            this.facturacionLegado = facturacionLegado;
        }
        public void EmitirFactura(string cliente, decimal total, string moneda)
        {
            int totalEnCentavos = (int)(total * 100);
            facturacionLegado.GenerarFactura(cliente, totalEnCentavos, moneda);
        }
       
    }
}
