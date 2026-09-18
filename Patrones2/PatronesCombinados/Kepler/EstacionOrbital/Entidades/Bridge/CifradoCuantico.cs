namespace EstacionOrbital.Entidades.Bridge
{
    public class CifradoCuantico : ICifrado
    {
        public string Nombre => "Cifrado Cuántico";
        public string Cifrar(string contenido)
        {
            char[] letras = contenido.ToCharArray();
            Array.Reverse(letras);
            string resultado = "<qubit>" + new string(letras) + "</qubit>";
            return resultado;
        }
    }
}
