using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class EmpleadoRD : Empleado
    {
        public decimal SueldoMensual { get; set; }
        public override decimal CalcularSueldo(int cantDias) => (SueldoMensual / 30) * cantDias;
    }
}
