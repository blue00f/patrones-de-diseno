using Iterator.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Departamento dep = new Departamento();
        dep.Agregar(new Empleado(1, "bruno", "QA", 1000m));
        dep.Agregar(new Empleado(2, "josé", "Líder Teçnico", 500m));
        dep.Agregar(new Empleado(3, "mario", "Developer", 2500m));
        dep.Agregar(new Empleado(4, "eduardo", "Analista Funcional", 3000m));

        Console.WriteLine("--- Recorrido normal ---");
        IIterator iterador = dep.CrearIterador();
        iterador.Primero();
        while (iterador.HaySiguiente())
        {
            Empleado emp = iterador.Actual();
            Console.WriteLine(emp);
            iterador.Siguiente();
        }

        Console.WriteLine("--- Recorrido inverso ---");
        IIterator iteradorInverso = dep.CrearIteradorInverso();
        iteradorInverso.Primero();
        while (iteradorInverso.HaySiguiente())
        {
            Empleado emp = iteradorInverso.Actual();
            Console.WriteLine(emp);
            iteradorInverso.Siguiente();
        }

        Console.ReadKey();
    }
}