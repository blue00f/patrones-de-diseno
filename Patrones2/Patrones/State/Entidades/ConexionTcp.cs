namespace State.Entidades
{
    public class ConexionTcp
    {
        private EstadoTcp estado;
        public ConexionTcp()
        {
            estado = TcpCerrado.Instancia;
        }
        public string EstadoActual => estado.Nombre;
        internal void CambiarEstado(EstadoTcp nuevoEstado)
        {
            Console.WriteLine($"\t(Transición: {estado.Nombre} -> {nuevoEstado.Nombre})");
            this.estado = nuevoEstado;
        }
        internal void ProcesarOctetos(string datos)
        {
            Console.WriteLine($"\tProcesando datos: '{datos}'");
        }
        public void AperturaActiva() => estado.AperturaActiva(this);
        public void AperturaPasiva() => estado.AperturaPasiva(this);
        public void Cerrar() => estado.Cerrar(this);
        public void Enviar() => estado.Enviar(this);
        public void Transmitir(string datos) => estado.Transmitir(this, datos);
    }
}
