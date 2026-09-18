namespace EstacionOrbital.Entidades.Bridge
{
    public interface ICifrado
    {
        string Nombre { get; }
        string Cifrar(string contenido);
    }
}
