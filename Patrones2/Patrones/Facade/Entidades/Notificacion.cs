namespace Facade.Entidades
{
    public class Notificacion
    {
        public void EnviarConfirmacion(string cliente, string codigoSeguimiento)
        {
            Console.WriteLine($"\t[Notificaciones] Email enviado a {cliente}: tu pedido está en camino (seguimiento: {codigoSeguimiento})");
        }
    }
}
