namespace Memento.Entidades
{
    public class ConfiguracionPerfil
    {
        public string NombreUsuario { get; set; }
        public string TemaVisual { get; set; }
        public int TamanioFuente { get; set; }
        public ConfiguracionPerfil(string nombreUsuario, string temaVisual, int tamanioFuente)
        {
            NombreUsuario = nombreUsuario;
            TemaVisual = temaVisual;
            TamanioFuente = tamanioFuente;
        }
        public Memento Crear() => new Memento(NombreUsuario, TemaVisual, TamanioFuente);
        public void Restaurar(Memento memento)
        {
            NombreUsuario = memento.NombreUsuario;
            TemaVisual = memento.TemaVisual;
            TamanioFuente = memento.TamanioFuente;
        }
        public override string ToString() => $"Usuario: {NombreUsuario} | Tema: {TemaVisual} | Tamaño de la fuente: {TamanioFuente}";
    }
}
