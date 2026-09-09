using Bridge.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Reporte Detallado exportado a PDF =====");
        Reporte rep1 = new ReporteDetallado(new ExportadorPdf());
        rep1.Generar();

        Console.WriteLine("\n===== Reporte Detallado exportado a Excel =====");
        Reporte rep2 = new ReporteDetallado(new ExportadorExcel());
        rep2.Generar();

        Console.WriteLine("\n===== Reporte Resumido exportado a PDF =====");
        Reporte rep3 = new ReporteResumido(new ExportadorPdf());
        rep3.Generar();

        Console.WriteLine("\n===== Mismo reporte resumido, cambiando el exportador a Excel en tiempo de ejecución =====");
        rep3.CambiarExportador(new ExportadorExcel());
        rep3.Generar();

        Console.ReadKey();
    }
}