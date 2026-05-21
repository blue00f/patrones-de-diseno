using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod2
{
    public class GuerreroCreator : PersonajeCreator
    {
        public override Personaje CrearPersonaje()
        {
            return new Guerrero();
        }
    }
}
