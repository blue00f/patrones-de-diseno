namespace EstacionOrbital.Entidades.Bridge
{
    public class CifradoAES : ICifrado
    {
        public string Nombre => "Cifrado AES";
        public string Cifrar(string contenido)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(contenido);
            string resultado = Convert.ToBase64String(bytes);
            return resultado;
        }
    }
}
