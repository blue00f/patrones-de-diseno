using Observer;

class Program
{
    static void Main(string[] args)
    {
        AlertaMovil am = new AlertaMovil("C202");
        PanelWeb pw = new PanelWeb("youtube.com");
        Almacenamiento alm = new Almacenamiento(500);

        EstacionCentral estacion = new EstacionCentral();
        estacion.Suscribir(am);
        estacion.Suscribir(pw);
        Console.Write("Temperatura (en grados): ");
        decimal temperatura = decimal.Parse(Console.ReadLine());
        estacion.CambiarTemperatura(temperatura);

    }
}