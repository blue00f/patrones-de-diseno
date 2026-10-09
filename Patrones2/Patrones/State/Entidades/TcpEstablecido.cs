namespace State.Entidades
{
    public class TcpEstablecido : EstadoTcp
    {
        public static readonly TcpEstablecido Instancia = new TcpEstablecido();
        private TcpEstablecido() { }
        public override string Nombre => "Establecido";
        public override void Cerrar(ConexionTcp conexion)
        {
            Console.WriteLine($"\t[{Nombre}] Enviando FIN, recibiendo ACK del FIN...");
            CambiarEstado(conexion, TcpEscucha.Instancia);
        }
        public override void Transmitir(ConexionTcp conexion, string datos)
        {
            conexion.ProcesarOctetos(datos);
        }
    }
}
