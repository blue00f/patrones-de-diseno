namespace FactoryMethod.Entidades
{
    public class ExcelCreator : ExportadorCreator
    {
        public override Exportador CrearExportador() => new ExcelExportador();
    }
}
