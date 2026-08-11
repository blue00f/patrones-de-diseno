using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Combo : IComponente
    {
        public string Nombre { get; set; }
        List<IComponente> hijos;
        public Combo(string nombre)
        {
            hijos = new List<IComponente>();
            Nombre = nombre;
        }
        public void Agregar(IComponente componente) => hijos.Add(componente);
        public void Borrar(IComponente componente) => hijos.Remove(componente);
        public List<IComponente> ObtenerHijos() => hijos;

        public void Mostrar()
        {
            Console.WriteLine($"\n{this.Nombre}:");
            foreach (IComponente c in hijos)
            {
                c.Mostrar();
            }
        }
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (IComponente c in hijos)
            {
                total += c.CalcularTotal();
            }
            return total;
        }
    }
}
