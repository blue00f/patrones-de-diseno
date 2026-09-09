namespace Bridge.Entidades
{
    public class ExportadorExcel : IExportador
    {
        public void Exportar(string tituloReporte, List<string> contenido)
        {
            Console.WriteLine($"[Excel] Generando '{tituloReporte}.xlsx'...");
            foreach (var linea in contenido)
            {
                Console.WriteLine($"\t| {linea} |");
            }
        }
    }
}
