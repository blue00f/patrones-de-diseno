namespace EstacionOrbital.Entidades.Proxy
{
    public class ProxyBoveda : IBoveda
    {
        private static readonly string[] rolesPermitidos = { "Capitan", "OficialSeguridad" };
        private readonly BovedaDatos bovedaReal;
        private readonly string usuario;
        private readonly string rol;
        public ProxyBoveda(string usuario, string rol)
        {
            this.bovedaReal = new BovedaDatos();
            this.usuario = usuario;
            this.rol = rol;
        }
        public string LeerArchivo(string id)
        {
            string resultado = null;

            if (TieneAcceso("leer " + id))
            {
                resultado = bovedaReal.LeerArchivo(id);
            }

            return resultado;
        }
        public void EscribirArchivo(string id, string contenido)
        {
            if (TieneAcceso("escribir " + id))
            {
                bovedaReal.EscribirArchivo(id, contenido);
            }
        }
        private bool TieneAcceso(string operacion)
        {
            bool permitido = rolesPermitidos.Contains(rol);

            if (permitido)
            {
                Console.WriteLine($"  [Proxy] Acceso concedido a {usuario} ({rol}).");
            }
            else
            {
                Console.WriteLine($"  [Proxy][LOG] {DateTime.Now:HH:mm:ss} ACCESO DENEGADO: {usuario} ({rol}) intentó {operacion}.");
            }
            return permitido;
        }
    }
}
