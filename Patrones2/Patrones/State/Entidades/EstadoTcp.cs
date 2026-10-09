namespace State.Entidades
{
    public abstract class EstadoTcp
    {
        public abstract string Nombre { get; }
        public virtual void AperturaActiva(ConexionTcp conexion) => OperacionNoValida("AperturaActiva");
        public virtual void AperturaPasiva(ConexionTcp conexion) => OperacionNoValida("AperturaPasiva");
        public virtual void Cerrar(ConexionTcp conexion) => OperacionNoValida("Cerrar");
        public virtual void Enviar(ConexionTcp conexion) => OperacionNoValida("Enviar");
        public virtual void Transmitir(ConexionTcp conexion, string datos) => OperacionNoValida("Transmitir");
        protected void CambiarEstado(ConexionTcp conexion, EstadoTcp nuevoEstado)
        {
            conexion.CambiarEstado(nuevoEstado);
        }
        protected void OperacionNoValida(string operacion)
        {
            Console.WriteLine($"\t[{Nombre}] La operación '{operacion}' no es válida en este estado.");
        }
    }
}
