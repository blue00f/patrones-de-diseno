using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entidades
{
    public class Empresa
    {
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public string Direccion { get; set; }

        public Empresa(string razonSocial, string cuit, string direccion)
        {
            RazonSocial = razonSocial;
            Cuit = cuit;
            Direccion = direccion;
        }

    }
}
