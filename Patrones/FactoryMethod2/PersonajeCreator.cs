using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod2
{
    // Creator
    public abstract class PersonajeCreator
    {
        public abstract Personaje CrearPersonaje();
    }
}
