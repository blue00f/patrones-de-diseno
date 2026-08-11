using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class EmpleadoRDCreator : EmpleadoCreator
    {
        public override Empleado CrearEmpleado()
        {
            return new EmpleadoRD();
        }
    }
}
