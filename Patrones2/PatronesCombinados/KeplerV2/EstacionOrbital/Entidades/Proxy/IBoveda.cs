namespace EstacionOrbital.Entidades.Proxy
{
    public interface IBoveda
    {
        string LeerArchivo(string id);
        void EscribirArchivo(string id, string contenido);
    }
}
