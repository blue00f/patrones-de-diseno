namespace FactoryMethod.Entidades
{
    public class PdfExportador : Exportador
    {
        public override void ExportarReporte() => MessageBox.Show("Exportando a PDF...");
    }
}
