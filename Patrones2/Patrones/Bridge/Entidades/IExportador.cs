namespace Bridge.Entidades
{
    public interface IExportador
    {
        void Exportar(string tituloReporte, List<string> contenido);
    }
}
