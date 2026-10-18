namespace DigitoVerificador.Entidades
{
    [Verificable("cliente")]
    public class Cliente : Entity, ISaludable
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Cliente(string nombre, string apellido, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }
        public void Saludar()
        {
            Console.WriteLine($"Hola {Nombre} {Apellido}");
        }
    }
}
