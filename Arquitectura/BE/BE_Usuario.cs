namespace BE
{
    public class BE_Usuario
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public bool Bloqueo { get; set; }
        public bool Activo { get; set; }
        public int CantIntentos { get; set; }
        public BE_Usuario(string dni, string nombre, string apellido, string correo)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Usuario = apellido.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries)[0] + dni;
            Password = dni + apellido.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
            Bloqueo = false;
            Activo = true;
            CantIntentos = 0;
        }
        public BE_Usuario(string dni, string nombre, string apellido, string correo, string usuario, string password, bool bloqueo, bool activo, int cantIntentos)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Usuario = usuario;
            Password = password;
            Bloqueo = bloqueo;
            Activo = activo;
            CantIntentos = cantIntentos;
        }
    }

}
