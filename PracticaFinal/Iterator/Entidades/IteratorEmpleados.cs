namespace Iterator.Entidades
{
    public class IteratorEmpleados : IIterator
    {
        Departamento departamento;
        int pos;
        public IteratorEmpleados(Departamento departamento)
        {
            this.departamento = departamento;
            pos = 0;
        }
        public void Primero() => pos = 0;
        public void Siguiente() => pos++;
        public bool HaySiguiente() => pos < departamento.Cantidad();
        public Empleado Actual() => departamento.Obtener(pos);
    }
}
