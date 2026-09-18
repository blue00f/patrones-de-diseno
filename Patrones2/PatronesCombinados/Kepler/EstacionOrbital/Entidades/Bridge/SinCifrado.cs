namespace EstacionOrbital.Entidades.Bridge
{
    public class SinCifrado : ICifrado
    {
        public string Nombre => "Sin cifrado";
        public string Cifrar(string contenido) => contenido.ToLowerInvariant();
    }
}
