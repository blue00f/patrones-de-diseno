using System;
using System.Collections.Generic;
using System.Text;

namespace Composite2
{
    public class Combo : IMenu
    {
        public string Nombre { get; set; }
        List<IMenu> elementos;
        public Combo(string nombre)
        {
            Nombre = nombre;
            elementos = new List<IMenu>();
        }

        public void Agregar(IMenu elemento) => elementos.Add(elemento);

        public void Mostrar(int nivel = 0)
        {
            Console.WriteLine($"{new string(' ', nivel * 3)}Combo: {Nombre} - Total: ${ObtenerPrecio()}");

            foreach (IMenu elemento in elementos)
            {
                elemento.Mostrar(nivel + 1);
            }
        }

        public decimal ObtenerPrecio()
        {
            decimal total = 0;
            foreach (IMenu e in elementos)
            {
                total += e.ObtenerPrecio();
            }
            return total;
        }
    }
}
