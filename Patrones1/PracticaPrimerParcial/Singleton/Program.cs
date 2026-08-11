namespace Singleton;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("conectando a base de datos...\nIngrese credenciales:");
        Singleton con1 = Singleton.ObtenerInstancia();
        Console.WriteLine($"user={con1.Nombre};clave={con1.Clave}");

        Singleton con2 = Singleton.ObtenerInstancia();
        Console.WriteLine("conectando a base de datos...\nIngrese credenciales:");
        Console.WriteLine($"user={con2.Nombre};clave={con2.Clave}");

        if(con1 == con2)
        {
            Console.WriteLine("ambas conexiones son iguales");
        }

        Console.ReadKey();
    }
}