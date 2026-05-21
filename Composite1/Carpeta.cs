using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Carpeta : IElemento
    {
        public string Nombre { get; private set; }
        List<IElemento> elementos;
        public Carpeta(string nombre)
        {
            Nombre = nombre;
            elementos = new List<IElemento>();
        }
        public void Agregar(IElemento elemento) => elementos.Add(elemento);
        public int ObtenerTamanio()
        {
            int total = 0;
            foreach(IElemento e in elementos)
            {
                total += e.ObtenerTamanio();
            }
            return total;
        }

        public void Mostrar(int nivel = 0)
        {
            Console.WriteLine($"{new string(' ', nivel * 3)}Carpeta: {Nombre} - Tamaño Total: {ObtenerTamanio()} KB");
            foreach (IElemento e in elementos)
            {
                e.Mostrar(nivel + 1);
            }
        }
    }
}
