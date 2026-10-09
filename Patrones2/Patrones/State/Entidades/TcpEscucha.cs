namespace State.Entidades
{
    public class TcpEscucha : EstadoTcp
    {
        public static readonly TcpEscucha Instancia = new TcpEscucha();
        private TcpEscucha() { }
        public override string Nombre => "Escucha";
        public override void Enviar(ConexionTcp conexion)
        {
            Console.WriteLine($"\t[{Nombre}] Enviando SYN, recibiendo SYN+ACK, enviando ACK...");
            CambiarEstado(conexion, TcpEstablecido.Instancia);
        }
    }
}
