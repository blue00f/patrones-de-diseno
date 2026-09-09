namespace Bridge.Entidades
{
    public class ExportadorPdf : IExportador
    {
        public void Exportar(string tituloReporte, List<string> contenido)
        {
            Console.WriteLine($"[PDF] Generando '{tituloReporte}.pdf'...");
            foreach (var linea in contenido)
            {
                Console.WriteLine($"\t{linea}");
            }
        }
    }
}
