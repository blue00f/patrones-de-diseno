namespace Memento.Entidades
{
    public class Memento
    {
        public string NombreUsuario { get; }
        public string TemaVisual { get; }
        public int TamanioFuente { get; }

        internal Memento(string nombreUsuario, string temaVisual, int tamanioFuente)
        {
            NombreUsuario = nombreUsuario;
            TemaVisual = temaVisual;
            TamanioFuente = tamanioFuente;
        }
    }
}
