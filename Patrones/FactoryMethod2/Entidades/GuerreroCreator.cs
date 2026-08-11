namespace FactoryMethod2.Entidades
{
    public class GuerreroCreator : PersonajeCreator
    {
        public override Personaje CrearPersonaje()
        {
            return new Guerrero();
        }
    }
}
