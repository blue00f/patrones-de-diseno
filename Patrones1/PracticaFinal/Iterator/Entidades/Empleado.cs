namespace Iterator.Entidades
{
    public class Empleado
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public decimal SueldoBasico { get; set; }
        public Empleado(int legajo, string nombre, string puesto, decimal sueldoBasico)
        {
            Legajo = legajo;
            Nombre = nombre;
            Puesto = puesto;
            SueldoBasico = sueldoBasico;
        }
        public override string ToString() => $"Legajo {this.Legajo}, Nombre: {this.Nombre}, Puesto: {this.Puesto}, Sueldo básico: {this.SueldoBasico}";
    }
}
