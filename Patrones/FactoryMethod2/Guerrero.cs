using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod2
{
    // Producto concreto
    public class Guerrero : Personaje
    {
        public override void Atacar()
        {
            Console.WriteLine("El guerrero ataca con espada");
        }
    }
}
