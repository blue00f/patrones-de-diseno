namespace Iterator.Entidades
{
    public class Departamento : IColeccion
    {
        List<Empleado> empleados;
        public Departamento()
        {
            empleados = new List<Empleado>();
        }
        public void Agregar(Empleado emp) => empleados.Add(emp);
        public Empleado Obtener(int i) => empleados[i];
        public int Cantidad() => empleados.Count;
        public IIterator CrearIterador() => new IteratorEmpleados(this);
        public IIterator CrearIteradorInverso() => new IteratorEmpleadosInverso(this);
    }
}
