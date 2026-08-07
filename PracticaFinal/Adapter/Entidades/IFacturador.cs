namespace Adapter.Entidades
{
    public interface IFacturador
    {
        void EmitirFactura(string cliente, decimal total, string moneda);
    }
}
