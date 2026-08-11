namespace FactoryMethod.Entidades
{
    public class CsvCreator : ExportadorCreator
    {
        public override Exportador CrearExportador() => new CsvExportador();
    }
}
