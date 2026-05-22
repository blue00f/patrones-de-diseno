using FactoryMethod;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Empresa empresa = new Empresa();
        int opc = 0;
        string nombre, apellido;
        int legajo;
        EmpleadoCreator creador;
        while(opc != 4)
        {
            
            Console.WriteLine("1.Ingresar empleado con relación de dependencia\n2.Ingresar empleado contratado\n3.Calcular sueldo por legajo y por cantidad de días\n4.Salir");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    creador = new EmpleadoRDCreator();
                    Empleado emp = creador.CrearEmpleado();

                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    apellido = Console.ReadLine();
                    Console.Write("Legajo: ");
                    legajo = int.Parse(Console.ReadLine());

                    emp.Nombre = nombre;
                    emp.Apellido = apellido;
                    emp.Legajo = legajo;

                    EmpleadoRD empRD = (EmpleadoRD)emp;
                
                    Console.Write("Sueldo mensual: ");
                    decimal sueldoMensual = decimal.Parse(Console.ReadLine());

                    empRD.SueldoMensual = sueldoMensual;

                    empresa.AgregarEmpleado(empRD);

                    break;
                case 2:
                    creador = new EmpleadoContratadoCreator();
                    emp = creador.CrearEmpleado();
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    apellido = Console.ReadLine();
                    Console.Write("Legajo: ");
                    legajo = int.Parse(Console.ReadLine());

                    emp.Nombre = nombre;
                    emp.Apellido = apellido;
                    emp.Legajo = legajo;

                    EmpleadoContratado empCon = (EmpleadoContratado)emp;

                    Console.Write("Importe por hora: ");
                    decimal importePorHora = decimal.Parse(Console.ReadLine());
                    Console.Write("Retención de impuestos: ");
                    decimal retencionImpuestos = decimal.Parse(Console.ReadLine());

                    empCon.ImportePorHora = importePorHora;
                    empCon.RetencionImpuesto = retencionImpuestos;

                    empresa.AgregarEmpleado(empCon);
                    break;
                case 3:
                    Console.Write("Legajo: ");
                    legajo = int.Parse(Console.ReadLine());
                    emp = empresa.BuscarEmpleadoPorLegajo(legajo);
                    Console.Write("Cantidad de días: ");
                    int dias = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Legajo: {emp.Legajo};Sueldo total: {emp.CalcularSueldo(dias).ToString()}");
                    break;
                default:
                    Console.Clear();
                    break;
            }

        }

        Console.ReadLine();
    }
}