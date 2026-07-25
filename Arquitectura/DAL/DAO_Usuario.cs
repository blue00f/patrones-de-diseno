using System.Data;

namespace DAL
{
    public class DAO_Usuario
    {
        ComandoBD comando;
        public DAO_Usuario()
        {
            comando = new();
        }

        public void Agregar(List<ParametroBD> parametros)
        {
            comando.Ejecutar("insert into usuario(dni,nombre,apellido,correo,nombreUsuario,password,bloqueo,activo,cantIntentos) values" +
                " (@dni,@nombre,@apellido,@correo,@nombreUsuario,@password,@bloqueo,@activo,@cantIntentos)", parametros);
        }
        public DataTable Consultar()
        {
            return comando.Consultar("select * from usuario");
        }
    }
}
