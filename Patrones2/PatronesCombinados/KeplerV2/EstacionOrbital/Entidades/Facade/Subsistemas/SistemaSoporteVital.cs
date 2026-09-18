namespace EstacionOrbital.Entidades.Facade.Subsistemas
{
    public class SistemaSoporteVital
    {
        public void Activar() => Console.WriteLine("  [Soporte Vital] Oxígeno y presión estables.");
        public void MaximaPrioridad() => Console.WriteLine("  [Soporte Vital] Prioridad máxima de oxígeno.");
        public void ModoMinimo() => Console.WriteLine("  [Soporte Vital] Funcionando al mínimo.");
    }
}
