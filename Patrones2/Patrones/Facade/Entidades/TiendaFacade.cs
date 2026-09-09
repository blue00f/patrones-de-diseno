namespace Facade.Entidades
{
    public class TiendaFacade
    {
        Inventario inventario;
        Pago pago;
        Envio envio;
        Notificacion notificacion;
        public TiendaFacade()
        {
            inventario = new();
            pago = new();
            envio = new();
            notificacion = new();
        }
        public bool ComprarProducto(string cliente, string producto, int cantidad, decimal monto, string metodoPago, string direccion)
        {
            bool rdo = false;
            Console.WriteLine($"=== Iniciando compra: {producto} para {cliente} ===");
            if (!inventario.HayStock(producto, cantidad))
            {
                Console.WriteLine("Compra cancelada: sin stock.");
                rdo = true;
            }

            if (!pago.ProcesarPago(metodoPago, monto))
            {
                Console.WriteLine("Compra cancelada: pago rechazado.");
                rdo = true;
            }
            inventario.DescontarStock(producto, cantidad);
            string codigoSeguimiento = envio.GenerarEtiquetaEnvio(direccion);
            notificacion.EnviarConfirmacion(cliente, codigoSeguimiento);
            return rdo;
        }
    }
}
