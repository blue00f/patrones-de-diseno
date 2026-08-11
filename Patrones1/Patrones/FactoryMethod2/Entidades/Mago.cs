namespace FactoryMethod2.Entidades
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
