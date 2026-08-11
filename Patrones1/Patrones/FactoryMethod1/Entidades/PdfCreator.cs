namespace FactoryMethod.Entidades
{
    public class PdfCreator : ExportadorCreator
    {
        public override Exportador CrearExportador() => new PdfExportador();
    }
}
