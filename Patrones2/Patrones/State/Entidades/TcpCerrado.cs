namespace State.Entidades
{
    public class TcpCerrado : EstadoTcp
    {
        public static readonly TcpCerrado Instancia = new TcpCerrado();
        private TcpCerrado() { }
        public override string Nombre => "Cerrado";
        public override void AperturaActiva(ConexionTcp conexion)
        {
            Console.WriteLine($"\t[{Nombre}] Enviando SYN, recibiendo SYN+ACK, enviando ACK...");
            CambiarEstado(conexion, TcpEstablecido.Instancia);
        }
        public override void AperturaPasiva(ConexionTcp conexion)
        {
            Console.WriteLine($"\t[{Nombre}] Esperando conexiones entrantes...");
            CambiarEstado(conexion, TcpEscucha.Instancia);
        }
    }
}
