namespace Proxy.Entidades
{
    public class ImagenMedicaProxy : IImagenMedica
    {
        public string NombreArchivo { get; set; }
        ImagenMedicaReal imagenReal;
        public ImagenMedicaProxy(string nombreArchivo)
        {
            NombreArchivo = nombreArchivo;
            Console.WriteLine($"[Proxy] Referencia liviana creada para '{nombreArchivo}' (aún sin cargar)");
        }
        public void Mostrar()
        {
            if (imagenReal == null)
            {
                Console.WriteLine($"[Proxy] Primer acceso a '{this.NombreArchivo}': cargando el objeto real...");
                imagenReal = new ImagenMedicaReal(this.NombreArchivo);
            }
            else
            {
                Console.WriteLine($"[Proxy] '{this.NombreArchivo}' ya estaba cargado, reutilizando...");
            }
            imagenReal.Mostrar();
        }
    }
}
