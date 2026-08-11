using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Empresa
    {
        private List<Empleado> empleados;
        public Empresa()
        {
            empleados = new List<Empleado>();
        }
        public void AgregarEmpleado(Empleado empleado) => empleados.Add(empleado);
        public Empleado? BuscarEmpleadoPorLegajo(int legajo)
        {
            Empleado emp = empleados.Find(x => x.Legajo == legajo);
            return emp;
        }
    }
}
