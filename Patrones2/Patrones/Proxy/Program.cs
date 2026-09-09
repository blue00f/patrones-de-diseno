using Proxy.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Listando estudios del paciente (solo referencias livianas) =====\n");

        IImagenMedica radiografia = new ImagenMedicaProxy("radiografia_torax.dcm");
        IImagenMedica tomografia = new ImagenMedicaProxy("tomografia_abdomen.dcm");
        IImagenMedica resonancia = new ImagenMedicaProxy("resonancia_cerebro.dcm");

        Console.WriteLine("\n=== El usuario decide abrir solo la radiografía ===");
        radiografia.Mostrar(); // acá recién se dispara la carga pesada

        Console.WriteLine("\n=== El usuario vuelve a abrir la misma radiografía ===");
        radiografia.Mostrar(); // ya está cargada, no se repite el costo

        Console.WriteLine("\n=== La tomografía y la resonancia NUNCA se llegaron a cargar ===");
        Console.WriteLine("(el usuario nunca las abrió, así que no se gastó tiempo ni memoria en ellas)");

        Console.ReadKey();
    }
}