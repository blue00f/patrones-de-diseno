using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    internal class Archivo : IElemento
    {
        public string Nombre { get; private set; }

        int _tamanio;
        public Archivo(string nombre, int tamanio)
        {
            Nombre = nombre;
            _tamanio = tamanio;
        }
        public int ObtenerTamanio() => _tamanio;

        public void Mostrar() => Console.WriteLine($"\tArchivo: {Nombre} - {_tamanio} KB");
    }
}
