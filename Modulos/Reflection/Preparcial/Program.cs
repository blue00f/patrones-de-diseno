using Preparcial;
using System.Reflection;

class Program
{
    static Type tipoEmpleado = typeof(Empleado);
    static object empleado = null;
    static void Main(string[] args)
    {
        int opcion = -1;
        while (opcion != 0)
        {
            MostrarMenu();
            Console.Write("Seleccione una opción: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        InspeccionarEnsamblado();
                        break;

                    case 2:
                        AnalizarClase();
                        break;

                    case 3:
                        EnumerarPropiedadesYCampos();
                        break;

                    case 4:
                        EnumerarMetodos();
                        break;

                    case 5:
                        CrearEmpleado();
                        break;

                    case 6:
                        AsignarInformacion();
                        break;

                    case 7:
                        ConsultarInformacion();
                        break;

                    case 8:
                        MostrarInformacion();
                        break;

                    case 9:
                        ActualizarSueldo();
                        break;

                    case 10:
                        CalcularRemuneracionAnual();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido.");
                opcion = -1;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
    static void MostrarMenu()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("     SISTEMA DE EMPLEADOS");
        Console.WriteLine("====================================");
        Console.WriteLine("1. Inspeccionar ensamblado");
        Console.WriteLine("2. Analizar clase Empleado");
        Console.WriteLine("3. Enumerar propiedades y campos");
        Console.WriteLine("4. Enumerar métodos");
        Console.WriteLine("5. Crear empleado dinámicamente");
        Console.WriteLine("6. Asignar información al empleado");
        Console.WriteLine("7. Consultar información del empleado");
        Console.WriteLine("8. Mostrar información del empleado");
        Console.WriteLine("9. Aplicar aumento salarial del 10%");
        Console.WriteLine("10. Calcular remuneración anual");
        Console.WriteLine("0. Salir");
        Console.WriteLine("====================================");
    }
    static void InspeccionarEnsamblado()
    {
        Assembly a = Assembly.GetExecutingAssembly();
        Console.WriteLine("\nINSPECCIÓN DEL ENSAMBLADO");
        Console.WriteLine($"Nombre completo: {a.FullName}");
        Console.WriteLine($"Versión: {a.GetName().Version}");
        Console.WriteLine($"Ubicación: {a.Location}");
    }
    static void AnalizarClase()
    {
        Console.WriteLine("\nANÁLISIS DE LA CLASE EMPLEADO");
        Console.WriteLine($"Nombre: {tipoEmpleado.Name}");
        Console.WriteLine($"Nombre completo: {tipoEmpleado.FullName}");
        Console.WriteLine($"Es clase: {tipoEmpleado.IsClass}");
        Console.WriteLine($"Es pública: {tipoEmpleado.IsPublic}");
    }
    static void EnumerarPropiedadesYCampos()
    {
        Console.WriteLine("\nENUMERACIÓN DE PROPIEDADES Y CAMPOS");
        PropertyInfo[] propiedades = tipoEmpleado.GetProperties();
        FieldInfo[] campos = tipoEmpleado.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine("\nPropiedades:");
        foreach (PropertyInfo p in propiedades)
        {
            Console.WriteLine($"\t{p.Name} ({p.PropertyType.Name})");
        }
        Console.WriteLine("\nCampos:");
        foreach (FieldInfo c in campos)
        {
            Console.WriteLine($"\t{c.Name} ({c.FieldType.Name})");
        }
    }
    static void EnumerarMetodos()
    {
        Console.WriteLine("\nENUMERACIÓN DE MÉTODOS");
        MethodInfo[] metodos = tipoEmpleado.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
        foreach (MethodInfo m in metodos)
        {
            Console.WriteLine($"{m.Name}");
        }
    }
    static void CrearEmpleado()
    {
        Console.WriteLine("\nCREACIÓN DINÁMICA DEL EMPLEADO");
        empleado = Activator.CreateInstance(tipoEmpleado);
        Console.WriteLine("Empleado creado correctamente.");
    }
    static void AsignarInformacion()
    {
        Console.WriteLine("\nASIGNACIÓN DE INFORMACIÓN");
        if (VerificarEmpleado())
        {
            PropertyInfo propNombre = tipoEmpleado.GetProperty("Nombre");
            PropertyInfo propEdad = tipoEmpleado.GetProperty("Edad");
            PropertyInfo propLegajo = tipoEmpleado.GetProperty("Legajo");
            PropertyInfo propPuesto = tipoEmpleado.GetProperty("Puesto");
            PropertyInfo propSueldo = tipoEmpleado.GetProperty("SueldoMensual");
            propNombre.SetValue(empleado, "Paul");
            propEdad.SetValue(empleado, 24);
            propPuesto.SetValue(empleado, "Músico");
            propSueldo.SetValue(empleado, 4000m);
            Console.WriteLine("Información asignada correctamente.");
        }
    }
    static void ConsultarInformacion()
    {
        Console.WriteLine("\nCONSULTA DE INFORMACIÓN");
        if (VerificarEmpleado())
        {
            PropertyInfo propNombre = tipoEmpleado.GetProperty("Nombre");
            PropertyInfo propEdad = tipoEmpleado.GetProperty("Edad");
            PropertyInfo propPuesto = tipoEmpleado.GetProperty("Puesto");
            PropertyInfo propSueldo = tipoEmpleado.GetProperty("SueldoMensual");
            Console.WriteLine($"Nombre: {propNombre.GetValue(empleado, null)}");
            Console.WriteLine($"Edad: {propEdad.GetValue(empleado, null)}");
            Console.WriteLine($"Puesto: {propPuesto.GetValue(empleado, null)}");
            Console.WriteLine($"Sueldo mensual: {propSueldo.GetValue(empleado, null)}");
        }
    }
    static void MostrarInformacion()
    {
        Console.WriteLine("\nINVOCACIÓN DINÁMICA DEL MÉTODO");
        if (VerificarEmpleado())
        {
            MethodInfo metodo = tipoEmpleado.GetMethod("ToString");
            object resultado = metodo.Invoke(empleado, null);
            Console.WriteLine(resultado);
        }
    }
    static void ActualizarSueldo()
    {
        Console.WriteLine("\nACTUALIZACIÓN SALARIAL DEL 10%");
        if (VerificarEmpleado())
        {
            MethodInfo metodo = tipoEmpleado.GetMethod("AumentarPorcentajeSueldo");
            object[] parametros = { 0.1m };
            metodo.Invoke(empleado, parametros);
            PropertyInfo propSueldo = tipoEmpleado.GetProperty("SueldoMensual");
            object sueldoActualizado = propSueldo.GetValue(empleado, null);
            Console.WriteLine($"Sueldo actualizado: ${sueldoActualizado}");
        }
    }
    static void CalcularRemuneracionAnual()
    {
        Console.WriteLine("\nCÁLCULO DE REMUNERACIÓN ANUAL");
        if (VerificarEmpleado())
        {
            MethodInfo metodo = tipoEmpleado.GetMethod("CalcularRemuneracionAnual");
            object resultado = metodo.Invoke(empleado, null);
            Console.WriteLine($"Remuneración anual: ${resultado}");
        }
    }
    static bool VerificarEmpleado()
    {
        bool creado = empleado != null;
        if (!creado) Console.WriteLine("Primero debe crear un empleado con la opción 5.");
        return creado;
    }
}
