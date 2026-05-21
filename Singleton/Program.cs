namespace Singleton;
class Program
{
    static void Main(string[] args)
    {
        ConectarBD("APP1");
        ConectarBD("APP2");
        ConectarBD("APP3");
    }

    public static void ConectarBD(string nombreApp)
    {
        Singleton con = Singleton.ObtenerInstancia();
        Console.WriteLine($"{nombreApp} conectándose a SQL Server...");
        Console.WriteLine($"credenciales: {con.Conexion}");
    }
}