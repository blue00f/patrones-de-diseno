using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod2
{
    // Producto concreto
    public class Mago : Personaje
    {
        public override void Atacar()
        {
            Console.WriteLine("El mago lanza un hechizo");
        }
    }
}
