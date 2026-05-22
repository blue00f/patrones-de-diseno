 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        public string Nombre { get; set; }
        public string Clave { get; set; }
        private static Singleton? instancia;
        private Singleton(string nombre, string clave)
        {
            Nombre = nombre;
            Clave = clave;
        }
        public static Singleton ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Singleton("admin", "123456");
            }
            return instancia;
        }
    }
}
