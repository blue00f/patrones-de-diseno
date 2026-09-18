namespace EstacionOrbital.Entidades.Proxy
{
    public class BovedaDatos : IBoveda
    {
        private readonly Dictionary<string, string> archivos = new Dictionary<string, string>
        {
            { "A-001", "Coordenadas del agujero de gusano" },
            { "A-002", "Códigos de autodestrucción" }
        };

        public string LeerArchivo(string id)
        {
            string contenido = archivos.ContainsKey(id) ? archivos[id] : "(archivo inexistente)";
            Console.WriteLine($"  [Bóveda] Leyendo {id}: {contenido}");
            return contenido;
        }

        public void EscribirArchivo(string id, string contenido)
        {
            archivos[id] = contenido;
            Console.WriteLine($"  [Bóveda] Archivo {id} guardado.");
        }
    }
}
