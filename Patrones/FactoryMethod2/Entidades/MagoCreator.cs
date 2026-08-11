namespace FactoryMethod2.Entidades
{
    public class MagoCreator : PersonajeCreator
    {
        public override Personaje CrearPersonaje()
        {
            return new Mago();
        }
    }
}
