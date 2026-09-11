using System.Collections.Generic;
using PresupuestosPatrones.Prototype;

namespace PresupuestosPatrones.Modelos
{
    public class PresupuestoResumido : IPrototype<PresupuestoResumido>
    {
        public string NombreCliente { get; set; } = "";
        public string ApellidoCliente { get; set; } = "";
        public List<string> Items { get; set; } = new List<string>();
        public string CondicionPago { get; set; } = "";

        public PresupuestoResumido Clonar()
        {
            PresupuestoResumido copia = (PresupuestoResumido)this.MemberwiseClone();
            // MemberwiseClone copia la referencia de la lista, asi que la duplicamos
            copia.Items = new List<string>(this.Items);
            return copia;
        }

        public string Mostrar()
        {
            string salida = "=== PRESUPUESTO RESUMIDO ===\n";
            salida += $"Cliente: {NombreCliente} {ApellidoCliente}\n";
            salida += $"Items: {string.Join(", ", Items)}\n";
            salida += $"Condicion de pago: {CondicionPago}\n";
            return salida;
        }
    }
}
