namespace FactoryMethod.Entidades
{
    public class CsvExportador : Exportador
    {
        public override void ExportarReporte() => MessageBox.Show("Exportando a CSV...");
    }
}
