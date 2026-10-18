namespace Ej3
{
    public class Persona
    {
        private string codigoInterno = "PER-001";
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Persona()
        {
            Nombre = "Sin nombre";
            Edad = 0;
        }
        public string Saludar()
        {
            return "Hola, mi nombre es " + Nombre + " y tengo " + Edad + " años.";
        }
        public string Presentarse(string materia)
        {
            return "Estoy presentando un ejemplo de Reflection para la materia: " + materia;
        }
        public override string ToString()
        {
            return "Objeto Persona creado correctamente.";
        }
    }
}
