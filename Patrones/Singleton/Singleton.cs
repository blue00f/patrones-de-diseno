using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        public string Conexion { get; set; }
        private static Singleton instancia;
        private Singleton(string conexion)
        {
            Conexion = conexion;
        }
        static public Singleton ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Singleton("user=admin;password=123");
            }
            return instancia;
        }
    }
}
