namespace FactoryMethod.Entidades
{
    public class ExcelExportador : Exportador
    {
        public override void ExportarReporte() => MessageBox.Show("Exportando reporte a Excel...");
    }
}
