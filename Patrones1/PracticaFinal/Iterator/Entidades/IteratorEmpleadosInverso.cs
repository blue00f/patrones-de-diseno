namespace Iterator.Entidades
{
    public class IteratorEmpleadosInverso : IIterator
    {
        Departamento departamento;
        int pos;
        public IteratorEmpleadosInverso(Departamento departamento)
        {
            this.departamento = departamento;
            pos = departamento.Cantidad();
        }
        public void Primero() => pos = departamento.Cantidad() - 1;
        public void Siguiente() => pos--;
        public bool HaySiguiente() => pos >= 0;
        public Empleado Actual() => departamento.Obtener(pos);
    }
}
