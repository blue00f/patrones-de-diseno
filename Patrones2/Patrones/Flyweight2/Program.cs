using Flyweight2.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Documento documento = new Documento();

        Console.WriteLine("=== Escribiendo un documento con formato mixto ===\n");

        documento.Escribir("Informe de Turnos - Septiembre", "Arial", 18, "Negro", negrita: true);
        documento.Escribir(" Durante el mes se registraron un total de trescientos veinte turnos, ", "Arial", 12, "Negro", negrita: false);
        documento.Escribir("de los cuales doscientos ochenta fueron confirmados exitosamente. ", "Arial", 12, "Negro", negrita: false);
        documento.Escribir("Atención: ", "Arial", 18, "Negro", negrita: true);
        documento.Escribir("quedan cuarenta turnos pendientes de confirmación.", "Arial", 12, "Negro", negrita: false);

        Console.WriteLine("\n=== Documento renderizado ===");
        documento.Renderizar();
        documento.MostrarEstadisticas();
        Console.ReadKey();
    }
}