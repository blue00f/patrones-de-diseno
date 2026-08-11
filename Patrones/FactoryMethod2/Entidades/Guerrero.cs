namespace FactoryMethod2.Entidades
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
