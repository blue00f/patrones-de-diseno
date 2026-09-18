namespace EstacionOrbital.Entidades.Facade.Subsistemas
{
    public class SistemaInventario
    {
        public void Verificar() => Console.WriteLine("  [Inventario] Stock verificado.");
        public void Cerrar() => Console.WriteLine("  [Inventario] Inventario cerrado y guardado.");
    }
}
