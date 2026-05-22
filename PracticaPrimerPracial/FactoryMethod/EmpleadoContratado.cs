using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class EmpleadoContratado : Empleado
    {
        public decimal ImportePorHora { get; set; }
        public decimal RetencionImpuesto { get; set; }
        public override decimal CalcularSueldo(int cantDias)
        {
            decimal bruto = (cantDias * 8) * ImportePorHora;
            decimal descuento = bruto * RetencionImpuesto;
            return bruto - descuento;
        }
    }
}
