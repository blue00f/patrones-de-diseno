using System.Collections.Generic;

namespace PresupuestosPatrones.Builders
{
    public class Director
    {
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void CambiarBuilder(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstruirPresupuesto(string nombre, string apellido, List<string> items,
                                         string condicionPago, decimal descuento = 0, string notaFinal = "")
        {
            builder.Reiniciar();
            builder.AgregarCliente(nombre, apellido);
            builder.AgregarItems(items);
            builder.AgregarCondicionPago(condicionPago);

            if (descuento > 0)
            {
                builder.AgregarDescuento(descuento);
            }
            if (!string.IsNullOrEmpty(notaFinal))
            {
                builder.AgregarNotaFinal(notaFinal);
            }
        }
    }
}
