using System.Collections.Generic;
using PresupuestosPatrones.Modelos;

namespace PresupuestosPatrones.Builders
{
    public class PresupuestoDetalladoBuilder : IBuilder
    {
        private PresupuestoDetallado presupuesto = new PresupuestoDetallado();

        public void Reiniciar()
        {
            presupuesto = new PresupuestoDetallado();
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

        public void AgregarDescuento(decimal descuento)
        {
            presupuesto.Descuento = descuento;
        }

        public void AgregarNotaFinal(string nota)
        {
            presupuesto.NotaFinal = nota;
        }

        public PresupuestoDetallado ObtenerPresupuesto()
        {
            PresupuestoDetallado resultado = presupuesto;
            return resultado;
        }
    }
}
