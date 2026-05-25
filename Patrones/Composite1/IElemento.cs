using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public interface IElemento
    {
        string Nombre { get; }
        int ObtenerTamanio();
        void Mostrar();
    }
}
