namespace Preparcial
{
    public class Empleado
    {
        string legajo = "LEG-001";
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Puesto { get; set; }
        public decimal SueldoMensual { get; set; }

        public override string ToString()
        {
            return $"Legajo: {this.legajo} | {Nombre} {Edad} años | {Puesto} | Sueldo mensual: {SueldoMensual:C2}";
        }
        public decimal AumentarPorcentajeSueldo(decimal porcentaje)
        {
            decimal sueldoActualizado = SueldoMensual + (SueldoMensual * porcentaje);
            SueldoMensual = sueldoActualizado;
            return sueldoActualizado;
        }
        public decimal CalcularRemuneracionAnual()
        {
            decimal sueldoAnual = SueldoMensual * 12;
            return sueldoAnual;
        }
    }
}
