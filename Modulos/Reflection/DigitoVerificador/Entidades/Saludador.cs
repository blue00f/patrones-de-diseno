using System.Reflection;

namespace DigitoVerificador.Entidades
{
    public class Saludador
    {
        public static void Saludar(object entidad)
        {
            var iface = entidad.GetType().GetInterfaces().Where(i => i.Name.Equals("ISaludable")).FirstOrDefault();
            if (iface != null)
            {
                MethodInfo metodo = entidad.GetType().GetMethod("Saludar");
                metodo.Invoke(entidad, null);
            }
            else
            {
                Console.WriteLine("No se saluda");
            }
        }
    }
}
