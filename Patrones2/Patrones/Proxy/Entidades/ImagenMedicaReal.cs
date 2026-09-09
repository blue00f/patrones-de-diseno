namespace Proxy.Entidades
{
    public class ImagenMedicaReal : IImagenMedica
    {
        public string NombreArchivo { get; set; }
        public ImagenMedicaReal(string nombreArchivo)
        {
            NombreArchivo = nombreArchivo;
        }
        public void CargarDesdeDisco()
        {
            Console.WriteLine($"\t[Carga pesada] Leyendo archivo '{NombreArchivo}' desde disco...");
            Thread.Sleep(800); // simula el tiempo real que tomaría cargar una imagen de varios MB
            Console.WriteLine($"\t[Carga pesada] '{NombreArchivo}' cargado en memoria.");
        }
        public void Mostrar()
        {
            Console.WriteLine($"Mostrando en pantalla: {NombreArchivo}");
        }
    }
}
