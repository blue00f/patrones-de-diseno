using Ej3;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== REFLECTION EN C# ===");
        Console.WriteLine();

        /* Reflection permite inspeccionar información de un programa en tiempo de ejecución.
         * Con Reflection podemos:
         * - Obtener información del ensamblado actual.
         * - Obtener información de una clase.
         * - Listar métodos, propiedades y campos.
         * - Crear objetos dinámicamente.
         * - Leer y modificar valores.
         * - Invocar métodos.
         */

        // ------------------------------------------------------------
        // 1. Obtener información del ensamblado actual
        // ------------------------------------------------------------

        Assembly ensamblado = Assembly.GetExecutingAssembly();

        Console.WriteLine("INFORMACION DEL ENSAMBLADO");
        Console.WriteLine("Nombre completo: " + ensamblado.FullName);
        Console.WriteLine("Ubicacion: " + ensamblado.Location);
        Console.WriteLine();

        // ------------------------------------------------------------
        // 2. Obtener el tipo de una clase
        // ------------------------------------------------------------

        /* La clase Type representa la información de un tipo. Un tipo puede ser una clase, interfaz, enum, estructura, etc.*/

        Type tipoPersona = typeof(Persona);

        Console.WriteLine("INFORMACION DEL TIPO");
        Console.WriteLine("Nombre: " + tipoPersona.Name);
        Console.WriteLine("Nombre completo: " + tipoPersona.FullName);
        Console.WriteLine("Es clase: " + tipoPersona.IsClass);
        Console.WriteLine("Es publica: " + tipoPersona.IsPublic);
        Console.WriteLine();

        // ------------------------------------------------------------
        // 3. Listar propiedades de la clase
        // ------------------------------------------------------------

        Console.WriteLine("PROPIEDADES DE LA CLASE");

        PropertyInfo[] propiedades = tipoPersona.GetProperties();

        foreach (PropertyInfo propiedad in propiedades)
        {
            Console.WriteLine("- " + propiedad.Name + " (" + propiedad.PropertyType.Name + ")");
        }

        Console.WriteLine();

        // ------------------------------------------------------------
        // 4. Listar campos de la clase
        // ------------------------------------------------------------

        Console.WriteLine("CAMPOS DE LA CLASE");

        FieldInfo[] campos = tipoPersona.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (FieldInfo campo in campos)
        {
            Console.WriteLine("- " + campo.Name + " (" + campo.FieldType.Name + ")");
        }

        Console.WriteLine();

        // ------------------------------------------------------------
        // 5. Listar metodos de la clase
        // ------------------------------------------------------------

        Console.WriteLine("METODOS DE LA CLASE");

        MethodInfo[] metodos = tipoPersona.GetMethods(
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.DeclaredOnly
        );

        foreach (MethodInfo metodo in metodos)
        {
            Console.WriteLine("- " + metodo.Name);
        }

        Console.WriteLine();

        // ------------------------------------------------------------
        // 6. Crear una instancia dinamicamente con Activator
        // ------------------------------------------------------------

        /* Activator.CreateInstance permite crear un objeto en tiempo de ejecucion usando su Type. */

        object objetoPersona = Activator.CreateInstance(tipoPersona);

        Console.WriteLine("OBJETO CREADO DINAMICAMENTE");
        Console.WriteLine(objetoPersona);
        Console.WriteLine();

        // ------------------------------------------------------------
        // 7. Modificar propiedades usando Reflection
        // ------------------------------------------------------------

        PropertyInfo propiedadNombre = tipoPersona.GetProperty("Nombre");
        PropertyInfo propiedadEdad = tipoPersona.GetProperty("Edad");

        propiedadNombre.SetValue(objetoPersona, "Agustin", null);
        propiedadEdad.SetValue(objetoPersona, 25, null);

        Console.WriteLine("VALORES MODIFICADOS CON REFLECTION");
        Console.WriteLine("Nombre: " + propiedadNombre.GetValue(objetoPersona, null));
        Console.WriteLine("Edad: " + propiedadEdad.GetValue(objetoPersona, null));
        Console.WriteLine();

        // ------------------------------------------------------------
        // 8. Invocar un metodo usando Reflection
        // ------------------------------------------------------------

        MethodInfo metodoSaludar = tipoPersona.GetMethod("Saludar");

        object resultado = metodoSaludar.Invoke(objetoPersona, null);

        Console.WriteLine("METODO INVOCADO CON REFLECTION");
        Console.WriteLine(resultado);
        Console.WriteLine();

        // ------------------------------------------------------------
        // 9. Invocar un metodo con parametros
        // ------------------------------------------------------------

        MethodInfo metodoPresentarse = tipoPersona.GetMethod("Presentarse");

        object[] parametros = new object[] { "Trabajo de Diploma" };

        object resultadoPresentacion = metodoPresentarse.Invoke(objetoPersona, parametros);

        Console.WriteLine("METODO CON PARAMETROS INVOCADO CON REFLECTION");
        Console.WriteLine(resultadoPresentacion);
        Console.WriteLine();

        // ------------------------------------------------------------
        // 10. Leer un campo privado usando Reflection
        // ------------------------------------------------------------

        /* Para acceder a miembros privados se usan BindingFlags. Esto debe usarse con cuidado, porque rompe el encapsulamiento. */

        FieldInfo campoCodigoInterno = tipoPersona.GetField("codigoInterno", BindingFlags.NonPublic | BindingFlags.Instance);

        object valorCampoPrivado = campoCodigoInterno.GetValue(objetoPersona);

        Console.WriteLine("CAMPO PRIVADO LEIDO CON REFLECTION");
        Console.WriteLine("codigoInterno: " + valorCampoPrivado);
        Console.WriteLine();

        Console.WriteLine("Presione una tecla para finalizar...");
        Console.ReadKey();
    }
}