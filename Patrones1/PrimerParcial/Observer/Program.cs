using Observer.Entidades;

class Program
{
    static void Main(string[] args)
    {
        List<RepartidorObserver> repartidores = new List<RepartidorObserver>();
        List<MostradorObserver> mostradores = new List<MostradorObserver>();

        GestorPedidosProgramados gestor = new GestorPedidosProgramados();
        int opc = 1;
        
        while (opc != 5)
        {
            do
            {
                Console.WriteLine("\n1.Agregar repartidor\n2.Agregar mostrador\n3.Agregar producto\n4.Suscribir\n5.Salir");
                if (opc < 1 || opc > 6) Console.WriteLine("Opción errónea!");
                opc = int.Parse(Console.ReadLine());
            } while (opc < 1 || opc > 5);

            switch (opc)
            {
                case 1:
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    RepartidorObserver rep = new RepartidorObserver(nombre);
                    repartidores.Add(rep);
                    break;
                case 2:
                    Console.Write("Número del mostrador: ");
                    int numero = int.Parse(Console.ReadLine());
                    MostradorObserver mos = new MostradorObserver(numero);
                    mostradores.Add(mos);
                    break;
                case 3:
                    Console.Write("Nombre cliente: ");
                    string nombreCli = Console.ReadLine();
                    Console.Write("Dirección: ");
                    string direccion = Console.ReadLine();
                    Console.Write("Nombre producto: ");
                    string nombreProd = Console.ReadLine();

                    Pedido ped = new Pedido(nombreCli, direccion, nombreProd);
                    gestor.AgregarPedido(ped);
                    break;
                case 4:
                    if (repartidores.Count == 0 && mostradores.Count == 0)
                    {
                        Console.WriteLine("Tiene que estar cargado al menos un repartidor y mostrador!");
                    }
                    else
                    {
                        foreach (IObservador o in repartidores)
                        {
                            gestor.Suscribir(o);
                        }
                        foreach (IObservador o in mostradores)
                        {
                            gestor.Suscribir(o);
                        }
                        Console.WriteLine("Todos los repartidores y mostradores están suscriptos!");
                    }
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}