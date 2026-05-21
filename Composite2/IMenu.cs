using System;
using System.Collections.Generic;
using System.Text;

namespace Composite2
{
    public interface IMenu
    {
        public string Nombre { get; set; }
        decimal ObtenerPrecio();
        void Mostrar(int nivel = 0);
    }
}
