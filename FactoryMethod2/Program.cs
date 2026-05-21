using FactoryMethod2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.Guerrero\n2.Mago");
        Console.WriteLine("Seleccione personaje: ");
        
        try
        {
            string opcionStr = Console.ReadLine();
            if (!int.TryParse(opcionStr, out int opcion)) throw new Exception("Se debe ingresar un número");
            PersonajeCreator creador;
            if (opcion == 1)
            {
                creador = new GuerreroCreator();
            }
            else if (opcion == 2)
            {
                creador = new MagoCreator();
            }
            else
            {
                throw new Exception("Opción no válida");
            }
            Personaje per = creador.CrearPersonaje();
            per.Atacar();
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}