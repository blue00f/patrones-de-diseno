namespace Facade.Entidades
{
    public class Inventario
    {
        public bool HayStock(string producto, int cantidad)
        {
            Console.WriteLine($"\t[Inventario] Verificando stock de '{producto}' (x{cantidad})...");   
            return true; // Siempre da true, está simplificado a fines prácticos
        }
        public void DescontarStock(string producto, int cantidad)
        {
            cantidad -= 1;
            Console.WriteLine($"\t[Inventario] Stock descontado: '{producto}' (x{cantidad})");
        }
    }
}
