using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Entidades
{
    public class Pedido
    {
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public string NombreProducto { get; set; }

        public Pedido(string nombreCliente, string direccion, string nombreProducto)
        {
            NombreCliente = nombreCliente;
            Direccion = direccion;
            NombreProducto = nombreProducto;
        }
    }
}
