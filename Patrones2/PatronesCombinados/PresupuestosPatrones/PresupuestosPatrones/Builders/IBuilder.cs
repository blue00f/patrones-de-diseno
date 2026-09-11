using System.Collections.Generic;

namespace PresupuestosPatrones.Builders
{
    public interface IBuilder
    {
        void Reiniciar();
        void AgregarCliente(string nombre, string apellido);
        void AgregarItems(List<string> items);
        void AgregarCondicionPago(string condicion);
        void AgregarDescuento(decimal descuento);
        void AgregarNotaFinal(string nota);
    }
}
