using System.Collections.Generic;
using PresupuestosPatrones.Modelos;

namespace PresupuestosPatrones.Builders
{
    public class PresupuestoResumidoBuilder : IBuilder
    {
        private PresupuestoResumido presupuesto = new PresupuestoResumido();

        public void Reiniciar()
        {
            presupuesto = new PresupuestoResumido();
        }

        public void AgregarCliente(string nombre, string apellido)
        {
            presupuesto.NombreCliente = nombre;
            presupuesto.ApellidoCliente = apellido;
        }

        public void AgregarItems(List<string> items)
        {
            presupuesto.Items = new List<string>(items);
        }

        public void AgregarCondicionPago(string condicion)
        {
            presupuesto.CondicionPago = condicion;
        }

        public void AgregarDescuento(decimal descuento) { }

        public void AgregarNotaFinal(string nota) { }

        public PresupuestoResumido ObtenerPresupuesto()
        {
            PresupuestoResumido resultado = presupuesto;
            return resultado;
        }
    }
}
