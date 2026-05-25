using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Entidades
{
    public interface IObservador
    {
        void Actualizar(Pedido pedido);
    }
}
