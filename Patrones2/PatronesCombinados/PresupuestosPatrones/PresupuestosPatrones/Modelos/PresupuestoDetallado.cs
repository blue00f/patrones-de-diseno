using System.Collections.Generic;
using PresupuestosPatrones.Prototype;

namespace PresupuestosPatrones.Modelos
{
    public class PresupuestoDetallado : IPrototype<PresupuestoDetallado>
    {
        public string NombreCliente { get; set; } = "";
        public string ApellidoCliente { get; set; } = "";
        public List<string> Items { get; set; } = new List<string>();
        public string CondicionPago { get; set; } = "";
        public decimal Descuento { get; set; }
        public string NotaFinal { get; set; } = "";

        public PresupuestoDetallado Clonar()
        {
            PresupuestoDetallado copia = (PresupuestoDetallado)this.MemberwiseClone();
            copia.Items = new List<string>(this.Items);
            return copia;
        }

        public string Mostrar()
        {
            string salida = "=== PRESUPUESTO DETALLADO ===\n";
            salida += $"Cliente: {NombreCliente} {ApellidoCliente}\n";
            salida += "Items:\n";
            foreach (string item in Items)
            {
                salida += $"  - {item}\n";
            }
            salida += $"Condicion de pago: {CondicionPago}\n";
            if (Descuento > 0) salida += $"Descuento: {Descuento}%\n";
            if (!string.IsNullOrEmpty(NotaFinal)) salida += $"Nota: {NotaFinal}\n";
            return salida;
        }
    }
}
