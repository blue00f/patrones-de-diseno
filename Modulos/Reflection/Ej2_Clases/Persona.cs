namespace Ej2_Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public string Saludar() => $"Hola, soy {Nombre}, {Apellido}";
    }
}
