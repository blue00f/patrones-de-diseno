using Observer;

class Program
{
    static void Main(string[] args)
    {
        Semaforo sem = new Semaforo();
        Pantalla pan1 = new Pantalla("pantalla central");
        Alarma ala1 = new Alarma();

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("1.Ingresar un color\n2.Suscribir eventos\n3.Desuscribir eventos\n4.Salir\n");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Color: ");
                    string color = Console.ReadLine();
                    sem.CambiarColor(color);
                    break;
                case 2:
                    sem.Suscribir(pan1);
                    sem.Suscribir(ala1);
                    Console.WriteLine("Eventos suscriptos");
                    break;
                case 3:
                    sem.Desuscribir(pan1);
                    sem.Desuscribir(ala1);
                    Console.WriteLine("Eventos desuscriptos");
                    break;
                case 4:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}